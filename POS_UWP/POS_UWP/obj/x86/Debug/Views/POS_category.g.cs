﻿#pragma checksum "C:\Users\silve\Documents\카카오톡 받은 파일\POS_UWP\POS_UWP\Views\POS_category.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "1AE7AA3B7529EA691865923A54A3DE0A"
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
    partial class POS_category : 
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
                    this.btn_Close = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 18 "..\..\..\Views\POS_category.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btn_Close).Click += this.btn_Close_Click;
                    #line default
                }
                break;
            case 2:
                {
                    this.txtbox_Category = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                    #line 125 "..\..\..\Views\POS_category.xaml"
                    ((global::Windows.UI.Xaml.Controls.TextBox)this.txtbox_Category).KeyDown += this.txtbox_Category_KeyDown;
                    #line default
                }
                break;
            case 3:
                {
                    this.btn_Add = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 126 "..\..\..\Views\POS_category.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btn_Add).Click += this.btn_Add_Click;
                    #line default
                }
                break;
            case 4:
                {
                    this.btn_Change = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 127 "..\..\..\Views\POS_category.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btn_Change).Click += this.btn_Change_Click;
                    #line default
                }
                break;
            case 5:
                {
                    this.btn_Delete = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 128 "..\..\..\Views\POS_category.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btn_Delete).Click += this.btn_Delete_Click;
                    #line default
                }
                break;
            case 6:
                {
                    this.lv_Category = (global::Windows.UI.Xaml.Controls.ListView)(target);
                    #line 28 "..\..\..\Views\POS_category.xaml"
                    ((global::Windows.UI.Xaml.Controls.ListView)this.lv_Category).SelectionChanged += this.lv_Category_SelectionChanged;
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

