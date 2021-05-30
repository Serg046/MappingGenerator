using NUnit.Framework;
using SourceGenerator = MappingGenerator.OnBuildGenerator.SourceMappingGenerator;

namespace MappingGenerator.Test.SourceMappingGenerator
{
	public class SourceMappingGeneratorTests
	{
		[Test]
		public void should_generate_attribute()
		{
			var generatorTestHelper = new GeneratorTestHelper<SourceGenerator>();

			var output = generatorTestHelper.GetGeneratedOutput("");

			StringAssert.Contains("[System.AttributeUsage(System.AttributeTargets.Method, Inherited = false, AllowMultiple = false)]", output);
			StringAssert.Contains("internal sealed class GeneratedMapAttribute : System.Attribute", output);
		}

		[Test]
		public void should_be_able_to_generate_mapping_interface_implementation()
		{
			var generatorTestHelper = new GeneratorTestHelper<SourceGenerator>();

			var output = generatorTestHelper.GetGeneratedOutput(@"
class Model1
{
	public int Prop { get; set; }
}

class Model2
{
	public int Prop { get; set; }
}

partial class Mapper
{
	[MappingGenerator.GeneratedMap]
	public Model2 X(Model1 model1);
}
");
		}
	}
}
