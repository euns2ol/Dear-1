﻿#pragma checksum "C:\Users\myc\Desktop\SW_TEST\POS_UWP\POS_UWP\Views\POS_manager.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "E3A33A6FAD9472B27F5E030A02DF2209"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace POS_UWP.Views
{
    partial class POS_manager : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.cb_Position = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                    #line 13 "..\..\..\Views\POS_manager.xaml"
                    ((global::Windows.UI.Xaml.Controls.ComboBox)this.cb_Position).SelectionChanged += this.cb_Position_SelectionChanged;
                    #line default
                }
                break;
            case 2:
                {
                    this.cb_Name = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                }
                break;
            case 3:
                {
                    this.btn_Change = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 31 "..\..\..\Views\POS_manager.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btn_Change).Click += this.btn_Change_Click;
                    #line default
                }
                break;
            case 4:
                {
                    this.btn_Close = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 32 "..\..\..\Views\POS_manager.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btn_Close).Click += this.btn_Close_Click;
                    #line default
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

