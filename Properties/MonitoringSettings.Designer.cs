﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RCmanager.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.2.0.0")]
    internal sealed partial class MonitoringSettings : global::System.Configuration.ApplicationSettingsBase {
        
        private static MonitoringSettings defaultInstance = ((MonitoringSettings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new MonitoringSettings())));
        
        public static MonitoringSettings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public uint InitCode {
            get {
                return ((uint)(this["InitCode"]));
            }
            set {
                this["InitCode"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public int[] UserMonitoringTimeBase_ms {
            get {
                return ((int[])(this["UserMonitoringTimeBase_ms"]));
            }
            set {
                this["UserMonitoringTimeBase_ms"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public System.Drawing.Color[] LineColorRGB {
            get {
                return ((System.Drawing.Color[])(this["LineColorRGB"]));
            }
            set {
                this["LineColorRGB"] = value;
            }
        }
    }
}