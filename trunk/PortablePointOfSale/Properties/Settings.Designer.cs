﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProtablePointOfSale.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=G-13;Initial Catalog=ZuluPointOfSale;Persist Security Info=True;User " +
            "ID=sa;Password=dangerous99")]
        public string ZuluPointOfSaleConnectionString {
            get {
                return ((string)(this["ZuluPointOfSaleConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=G-13;Initial Catalog=PointOfSaleManagement;Persist Security Info=True" +
            ";User ID=sa;Password=dangerous99")]
        public string PointOfSaleManagementConnectionString {
            get {
                return ((string)(this["PointOfSaleManagementConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=192.168.1.151;Initial Catalog=PortablePOSDevEdition;Persist Security " +
            "Info=True;User ID=sa;Password=dangerous99")]
        public string PortablePOSDevEditionConnectionString {
            get {
                return ((string)(this["PortablePOSDevEditionConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=G-13;Initial Catalog=PortablePOSDevEdition;Persist Security Info=True" +
            ";User ID=sa;Password=dangerous99")]
        public string PortablePOSDevEditionConnectionString1 {
            get {
                return ((string)(this["PortablePOSDevEditionConnectionString1"]));
            }
        }
    }
}