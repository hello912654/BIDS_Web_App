﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BIDSMonitor.Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resource() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("BIDSMonitor.Resources.Resource", typeof(Resource).Assembly);
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
        ///   Looks up a localized string similar to 載入中.
        /// </summary>
        internal static string action_loading {
            get {
                return ResourceManager.GetString("action.loading", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 轉盤編號.
        /// </summary>
        internal static string flight_carouselNo {
            get {
                return ResourceManager.GetString("flight.carouselNo", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 報到.
        /// </summary>
        internal static string flight_checkinCount {
            get {
                return ResourceManager.GetString("flight.checkinCount", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 登機門.
        /// </summary>
        internal static string flight_departureGate {
            get {
                return ResourceManager.GetString("flight.departureGate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 差異.
        /// </summary>
        internal static string flight_differenceCount {
            get {
                return ResourceManager.GetString("flight.differenceCount", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 預計起飛時間.
        /// </summary>
        internal static string flight_ETD {
            get {
                return ResourceManager.GetString("flight.ETD", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 航班編號.
        /// </summary>
        internal static string flight_flightNo {
            get {
                return ResourceManager.GetString("flight.flightNo", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 目的地.
        /// </summary>
        internal static string flight_flightTo {
            get {
                return ResourceManager.GetString("flight.flightTo", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 分揀.
        /// </summary>
        internal static string flight_sortingCount {
            get {
                return ResourceManager.GetString("flight.sortingCount", resourceCulture);
            }
        }
    }
}
