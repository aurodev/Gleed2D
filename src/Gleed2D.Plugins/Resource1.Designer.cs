﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.239
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Gleed2D.Plugins {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resource1 {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resource1() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Gleed2D.Plugins.Resource1", typeof(Resource1).Assembly);
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
        ///   Looks up a localized string similar to (Left Click) = start new circle      (Right Click) = exit circle draw mode.
        /// </summary>
        internal static string Circle_Entered {
            get {
                return ResourceManager.GetString("Circle_Entered", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to (Left Click) = add circle to level      (Right Click) = cancel circle.
        /// </summary>
        internal static string Circle_Started {
            get {
                return ResourceManager.GetString("Circle_Started", resourceCulture);
            }
        }
        
        internal static System.Drawing.Bitmap FolderImage {
            get {
                object obj = ResourceManager.GetObject("FolderImage", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to (Left Click) = start new path      (Right Click) = exit path draw mode.
        /// </summary>
        internal static string Path_Entered {
            get {
                return ResourceManager.GetString("Path_Entered", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to (Left Click) = next point      (BackSpace) = delete last point      (Middle Click) = add path to level      (Right Click) = cancel path.
        /// </summary>
        internal static string Path_Started {
            get {
                return ResourceManager.GetString("Path_Started", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Move the rectangle and release the mouse.
        /// </summary>
        internal static string Rectangle_DragDrop {
            get {
                return ResourceManager.GetString("Rectangle_DragDrop", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to (Left Click) = start new rectangle      (Right Click) = exit rectangle draw mode.
        /// </summary>
        internal static string Rectangle_Entered {
            get {
                return ResourceManager.GetString("Rectangle_Entered", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to (Left Click) = add rectangle to level      (LeftCtrl) = make square      (Right Click) = cancel rectangle.
        /// </summary>
        internal static string Rectangle_Started {
            get {
                return ResourceManager.GetString("Rectangle_Started", resourceCulture);
            }
        }
    }
}
