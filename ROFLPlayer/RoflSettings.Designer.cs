﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ROFLPlayer {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.7.0.0")]
    internal sealed partial class RoflSettings : global::System.Configuration.ApplicationSettingsBase {
        
        private static RoflSettings defaultInstance = ((RoflSettings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new RoflSettings())));
        
        public static RoflSettings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string LoLExecLocation {
            get {
                return ((string)(this["LoLExecLocation"]));
            }
            set {
                this["LoLExecLocation"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int StartupMode {
            get {
                return ((int)(this["StartupMode"]));
            }
            set {
                this["StartupMode"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Etirps")]
        public string Username {
            get {
                return ((string)(this["Username"]));
            }
            set {
                this["Username"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("NA")]
        public string Region {
            get {
                return ((string)(this["Region"]));
            }
            set {
                this["Region"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("https://matchhistory.na.leagueoflegends.com/en/#match-details")]
        public string MatchHistoryBaseUrl {
            get {
                return ((string)(this["MatchHistoryBaseUrl"]));
            }
            set {
                this["MatchHistoryBaseUrl"] = value;
            }
        }
    }
}
