﻿#pragma checksum "C:\Users\silve\Documents\카카오톡 받은 파일\POS_UWP\POS_UWP\Views\POS_setting.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "621659C3C7562C93680D92A51E32816B"
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
    partial class POS_setting : 
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
                    this.cb_Category = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                    #line 109 "..\..\..\Views\POS_setting.xaml"
                    ((global::Windows.UI.Xaml.Controls.ComboBox)this.cb_Category).SelectionChanged += this.cb_Category_SelectionChanged;
                    #line default
                }
                break;
            case 2:
                {
                    this.txtbox_Name = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 3:
                {
                    this.txtbox_Price = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 4:
                {
                    this.tb_Category = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 5:
                {
                    this.tb_Name = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 6:
                {
                    this.tb_price = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 7:
                {
                    this.btn_Close = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 123 "..\..\..\Views\POS_setting.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btn_Close).Click += this.btn_Close_Click;
                    #line default
                }
                break;
            case 8:
                {
                    this.btn_Category = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 128 "..\..\..\Views\POS_setting.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btn_Category).Click += this.btn_Category_Click;
                    #line default
                }
                break;
            case 9:
                {
                    this.btn_ProductAdd = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 129 "..\..\..\Views\POS_setting.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btn_ProductAdd).Click += this.btn_ProductAdd_Click;
                    #line default
                }
                break;
            case 10:
                {
                    this.btn_ProductChange = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 130 "..\..\..\Views\POS_setting.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btn_ProductChange).Click += this.btn_ProductChange_Click;
                    #line default
                }
                break;
            case 11:
                {
                    this.btn_ProductDelete = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 131 "..\..\..\Views\POS_setting.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btn_ProductDelete).Click += this.btn_ProductDelete_Click;
                    #line default
                }
                break;
            case 12:
                {
                    this.lv_Product = (global::Windows.UI.Xaml.Controls.ListView)(target);
                    #line 15 "..\..\..\Views\POS_setting.xaml"
                    ((global::Windows.UI.Xaml.Controls.ListView)this.lv_Product).SelectionChanged += this.lv_Product_SelectionChanged;
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

