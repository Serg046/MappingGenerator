using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MappingGenerator.Mappings;
using MappingGenerator.RoslynHelpers;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Editing;
using Microsoft.CodeAnalysis.Text;

namespace MappingGenerator.OnBuildGenerator
{
	[Generator]
	public class SourceMappingGenerator : ISourceGenerator
	{
		private const string AttributeText = @"
namespace MappingGenerator
{
	[System.AttributeUsage(System.AttributeTargets.Method, Inherited = false, AllowMultiple = false)]
    internal sealed class GeneratedMapAttribute : System.Attribute
    {
    }
}
";
		private readonly MappingImplementorEngine _implementorEngine = new MappingImplementorEngine();

		public void Initialize(InitializationContext context)
		{
			context.RegisterForSyntaxNotifications(() => new SyntaxReceiver());
		}

		public void Execute(SourceGeneratorContext context)
		{
			if (!(context.SyntaxReceiver is SyntaxReceiver receiver))
			{
				return;
			}

			if (!(context.Compilation is CSharpCompilation csharpCompilation) || !(csharpCompilation.SyntaxTrees.FirstOrDefault()?.Options is CSharpParseOptions options))
			{
				return;
			}

			context.AddSource("GeneratedMapAttribute", SourceText.From(AttributeText, Encoding.UTF8));
			var compilation = context.Compilation.AddSyntaxTrees(CSharpSyntaxTree.ParseText(SourceText.From(AttributeText, Encoding.UTF8), options));

			foreach (var method in receiver.Methods)
			{
				var semanticModel = compilation.GetSemanticModel(method.SyntaxTree);
				var mappingContext = new MappingContext(method, semanticModel);
				var methodSymbol = semanticModel.GetDeclaredSymbol(method);
				if (_implementorEngine.CanProvideMappingImplementationFor(methodSymbol))
				{
					// TODO: SyntaxGenerator is not available here
					var x = _implementorEngine.GenerateMappingStatements(methodSymbol,
						null, semanticModel, mappingContext);
				}
			}
		}

		private class SyntaxReceiver : ISyntaxReceiver
		{
			public List<MethodDeclarationSyntax> Methods { get; } = new List<MethodDeclarationSyntax>();

			public void OnVisitSyntaxNode(SyntaxNode syntaxNode)
			{
				if (syntaxNode is MethodDeclarationSyntax methodDeclarationSyntax)
				{
					foreach (var attributeList in methodDeclarationSyntax.AttributeLists)
					foreach (var attribute in attributeList.Attributes)
					{
						if (attribute.Name.ToString() == "MappingGenerator.GeneratedMap")
						{
							Methods.Add(methodDeclarationSyntax);
							return;
						}
					}
				}
			}
		}
	}
}
