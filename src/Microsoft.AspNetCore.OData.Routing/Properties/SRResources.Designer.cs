﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.AspNetCore.OData.Routing {
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
    internal class SRResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal SRResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.AspNetCore.OData.Routing.Properties.SRResources", typeof(SRResources).Assembly);
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
        ///   Looks up a localized string similar to Cannot find the services container for the non-OData route. This can occur when using OData components on the non-OData route and is usually a configuration issue. Call EnableDependencyInjection() to enable OData components on non-OData routes. This may also occur when a request was mistakenly handled by the ASP.NET Core routing layer instead of the OData routing layer, for instance the URL does not include the OData route prefix configured via a call to MapODataServiceRoute()..
        /// </summary>
        internal static string MissingNonODataContainer {
            get {
                return ResourceManager.GetString("MissingNonODataContainer", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot find the services container for route &apos;{0}&apos;. This should not happen and represents a bug..
        /// </summary>
        internal static string MissingODataContainer {
            get {
                return ResourceManager.GetString("MissingODataContainer", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot find &apos;{0}&apos;. The OData services have not been configured. Are you missing a call to AddOData()?.
        /// </summary>
        internal static string MissingODataServices {
            get {
                return ResourceManager.GetString("MissingODataServices", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The container built by the container builder must not be null..
        /// </summary>
        internal static string NullContainer {
            get {
                return ResourceManager.GetString("NullContainer", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The request must have an associated EDM model. Consider using the extension method HttpConfiguration.MapODataServiceRoute to register a route that parses the OData URI and attaches the model information..
        /// </summary>
        internal static string RequestMustHaveModel {
            get {
                return ResourceManager.GetString("RequestMustHaveModel", resourceCulture);
            }
        }
    }
}
