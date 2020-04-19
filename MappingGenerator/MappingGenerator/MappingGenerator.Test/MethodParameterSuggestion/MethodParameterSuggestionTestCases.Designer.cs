﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MappingGenerator.Test.MethodParameterSuggestion {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class MethodParameterSuggestionTestCases {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal MethodParameterSuggestionTestCases() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("MappingGenerator.Test.MethodParameterSuggestion.MethodParameterSuggestionTestCase" +
                            "s", typeof(MethodParameterSuggestionTestCases).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to using System;
        ///using System.Collections.Generic;
        ///using System.Text;
        ///using System.Collections.ObjectModel;
        ///
        ///namespace MappingGenerator.Test.MappingGenerator.TestCaseData
        ///{
        ///    public class TestMapper
        ///    {
        ///        public static UserDTO Map(string firstName, string lastName, int age)
        ///        {
        ///            Map2([||]);
        ///        }
        ///
        ///        public static UserDTO Map2(string firstName, string lastName, int age)
        ///        {
        ///            
        ///        }
        ///    }
        ///
        ///}.
        /// </summary>
        internal static string _001_SuggestOuterMethodParameters {
            get {
                return ResourceManager.GetString("_001_SuggestOuterMethodParameters", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to using System;
        ///using System.Collections.Generic;
        ///using System.Text;
        ///using System.Collections.ObjectModel;
        ///
        ///namespace MappingGenerator.Test.MappingGenerator.TestCaseData
        ///{
        ///    public class TestMapper
        ///    {
        ///        public static UserDTO Map(string firstName, string lastName, int age)
        ///        {
        ///            var parent = new UserDTO();
        ///            Map2([||]);
        ///        }
        ///
        ///        public static UserDTO Map2(string firstName, string lastName, int age, UserDTO parent)
        ///        {
        ///            
        ///        } [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string _002_SuggestOuterMethodParametersAndLocal {
            get {
                return ResourceManager.GetString("_002_SuggestOuterMethodParametersAndLocal", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to using System;
        ///using System.Collections.Generic;
        ///using System.Text;
        ///using System.Collections.ObjectModel;
        ///
        ///namespace MappingGenerator.Test.MappingGenerator.TestCaseData
        ///{
        ///    public class TestMapper
        ///    {
        ///        private readonly UserDTO parent = new UserDTO();
        ///
        ///        public static UserDTO Map(string firstName, string lastName, int age)
        ///        {
        ///            Map2([||]);
        ///        }
        ///
        ///        public static UserDTO Map2(string firstName, string lastName, int age, UserDTO parent)
        ///        {
        ///     [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string _003_SuggestOuterMethodParametersAndMembers {
            get {
                return ResourceManager.GetString("_003_SuggestOuterMethodParametersAndMembers", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to using System;
        ///using System.Collections.Generic;
        ///using System.Text;
        ///using System.Collections.ObjectModel;
        ///
        ///namespace MappingGenerator.Test.MappingGenerator.TestCaseData
        ///{
        ///    public class TestMapper
        ///    {
        ///        public static UserDTO Map(string firstName, string lastName, int age)
        ///        {
        ///            var firstParent = new UserDTO();
        ///            Map2([||]);
        ///        }
        ///
        ///        public static UserDTO Map2(string firstName, string lastName, int age, UserDTO parent)
        ///        {
        ///            
        ///     [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string _004_FallbackByTypeIfSingleCandidate {
            get {
                return ResourceManager.GetString("_004_FallbackByTypeIfSingleCandidate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to using System;
        ///using System.Collections.Generic;
        ///using System.Text;
        ///using System.Collections.ObjectModel;
        ///
        ///namespace MappingGenerator.Test.MappingGenerator.TestCaseData
        ///{
        ///    public class TestMapper
        ///    {
        ///        IUserDTO firstParent = new UserDTO();
        ///
        ///        public static UserDTO Map(string firstName, string lastName, int age)
        ///        {
        ///            Map2([||]);
        ///        }
        ///
        ///        public static UserDTO Map2(string firstName, string lastName, int age, IUserDTO parent)
        ///        {
        ///            
        /// [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string _005_FallbackByTypeIfSingleCandidateInterface {
            get {
                return ResourceManager.GetString("_005_FallbackByTypeIfSingleCandidateInterface", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to using System;
        ///using System.Collections.Generic;
        ///using System.Text;
        ///using System.Collections.ObjectModel;
        ///
        ///namespace MappingGenerator.Test.MappingGenerator.TestCaseData
        ///{
        ///    public class TestMapper
        ///    {
        ///        EntityDTO firstParent = new UserDTO();
        ///
        ///        public static UserDTO Map(string firstName, string lastName, int age)
        ///        {
        ///            Map2([||]);
        ///        }
        ///
        ///        public static UserDTO Map2(string firstName, string lastName, int age, EntityDTO parent)
        ///        {
        ///             [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string _006_FallbackByTypeIfSingleCandidateBaseClass {
            get {
                return ResourceManager.GetString("_006_FallbackByTypeIfSingleCandidateBaseClass", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to using System;
        ///using System.Collections.Generic;
        ///using System.Text;
        ///using System.Collections.ObjectModel;
        ///
        ///namespace MappingGenerator.Test.MappingGenerator.TestCaseData
        ///{
        ///    public class TestMapper
        ///    {
        ///        UserDTO firstParent = new UserDTO();
        ///
        ///        public static UserDTO Map(string firstName, string lastName, int age)
        ///        {
        ///            Map2([||]);
        ///        }
        ///
        ///        public static UserDTO Map2(string firstName, string lastName, int age, IUserDTO parent)
        ///        {
        ///            
        ///  [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string _007_FallbackByTypeIfSingleCandidateInterfaceInheritance {
            get {
                return ResourceManager.GetString("_007_FallbackByTypeIfSingleCandidateInterfaceInheritance", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to using System;
        ///using System.Collections.Generic;
        ///using System.Text;
        ///using System.Collections.ObjectModel;
        ///
        ///namespace MappingGenerator.Test.MappingGenerator.TestCaseData
        ///{
        ///    public class TestMapper
        ///    {
        ///        UserDTO firstParent = new UserDTO();
        ///
        ///        public static UserDTO Map(string firstName, string lastName, int age)
        ///        {
        ///            Map2([||]);
        ///        }
        ///
        ///        public static UserDTO Map2(string firstName, string lastName, int age, EntityDTO parent)
        ///        {
        ///            
        /// [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string _008_FallbackByTypeIfSingleCandidateBaseClassInheritance {
            get {
                return ResourceManager.GetString("_008_FallbackByTypeIfSingleCandidateBaseClassInheritance", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to using System;
        ///using System.Collections.Generic;
        ///using System.Text;
        ///using System.Collections.ObjectModel;
        ///
        ///namespace MappingGenerator.Test.MappingGenerator.TestCaseData
        ///{
        ///    public class TestMapper
        ///    {
        ///
        ///        public static UserDTO Map(string firstName, string lastName, int age)
        ///        {
        ///            var user = new UserDTO();
        ///            user.Update([||]);
        ///            return user;
        ///        }
        ///    }
        ///
        ///    public class UserDTO
        ///    {
        ///    
        ///    }
        ///
        ///    public static class UserDTOExtensions        /// [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string _009_SuggestParamsForExtensionMethod {
            get {
                return ResourceManager.GetString("_009_SuggestParamsForExtensionMethod", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to using System;
        ///using System.Collections.Generic;
        ///using System.Text;
        ///using System.Collections.ObjectModel;
        ///
        ///namespace MappingGenerator.Test.MappingGenerator.TestCaseData
        ///{
        ///    public class TestMapper
        ///    {
        ///
        ///        public static UserDTO Map(string firstName, string lastName, IIdentityProvider  provider)
        ///        {
        ///            var user = new UserDTO();
        ///            user.Update([||]);
        ///            return user;
        ///        }
        ///    }
        ///
        ///    public class UserDTO
        ///    {
        ///    
        ///    }
        ///
        ///    public interface I [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string _010_SuggestParamsWithInterface {
            get {
                return ResourceManager.GetString("_010_SuggestParamsWithInterface", resourceCulture);
            }
        }
    }
}
