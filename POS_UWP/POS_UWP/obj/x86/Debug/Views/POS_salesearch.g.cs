﻿#pragma checksum "C:\Users\silve\Documents\카카오톡 받은 파일\POS_UWP\POS_UWP\Views\POS_salesearch.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "936DD5E3250C6BB0ECBA9776F97066DC"
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
    partial class POS_salesearch : 
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
                    #line 12 "..\..\..\Views\POS_salesearch.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btn_Close).Click += this.btn_Close_Click;
                    #line default
                }
                break;
            case 2:
                {
                    this.btn_Refund = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 134 "..\..\..\Views\POS_salesearch.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btn_Refund).Click += this.btn_Refund_Click;
                    #line default
                }
                break;
            case 3:
                {
                    this.txtbox_Sum = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 4:
                {
                    this.txtbox_Client = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 5:
                {
                    this.txtbox_Cash = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 6:
                {
                    this.txtbox_Cancel = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 7:
                {
                    this.txtbox_Receipt = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 8:
                {
                    this.txtbox_Card = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 9:
                {
                    this.lv_SaleMore = (global::Windows.UI.Xaml.Controls.ListView)(target);
                }
                break;
            case 10:
                {
                    this.lv_Sale = (global::Windows.UI.Xaml.Controls.ListView)(target);
                    #line 20 "..\..\..\Views\POS_salesearch.xaml"
                    ((global::Windows.UI.Xaml.Controls.ListView)this.lv_Sale).SelectionChanged += this.lv_Sale_SelectionChanged;
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

