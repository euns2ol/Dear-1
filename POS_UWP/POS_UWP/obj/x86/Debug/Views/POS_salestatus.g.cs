﻿#pragma checksum "C:\Users\myc\Desktop\SW_TEST\POS_UWP\POS_UWP\Views\POS_salestatus.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "984D784919A1A0B6CC89001C8174D822"
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
    partial class POS_salestatus : 
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
                    this.LineChart = (global::WinRTXamlToolkit.Controls.DataVisualization.Charting.Chart)(target);
                }
                break;
            case 2:
                {
                    this.PieChart = (global::WinRTXamlToolkit.Controls.DataVisualization.Charting.Chart)(target);
                }
                break;
            case 3:
                {
                    this.tb_nowAvg = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 4:
                {
                    this.tb_todayAvg = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 5:
                {
                    this.btn_Close = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 48 "..\..\..\Views\POS_salestatus.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btn_Close).Click += this.btn_Close_Click;
                    #line default
                }
                break;
            case 6:
                {
                    this.tb_select = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 7:
                {
                    this.txtbox_Top1 = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 8:
                {
                    this.txtbox_Top2 = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 9:
                {
                    this.txtbox_Top3 = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 10:
                {
                    this.tb_nowAvg_value = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 11:
                {
                    this.tb_todayAvg_value = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 12:
                {
                    this.tb_select_value = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 13:
                {
                    this.btn_Week = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 68 "..\..\..\Views\POS_salestatus.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btn_Week).Click += this.btn_Week_Click;
                    #line default
                }
                break;
            case 14:
                {
                    this.btn_Month = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 69 "..\..\..\Views\POS_salestatus.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btn_Month).Click += this.btn_Month_Click;
                    #line default
                }
                break;
            case 15:
                {
                    this.btn_Year = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 70 "..\..\..\Views\POS_salestatus.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btn_Year).Click += this.btn_Year_Click;
                    #line default
                }
                break;
            case 16:
                {
                    global::WinRTXamlToolkit.Controls.DataVisualization.Charting.LineSeries element16 = (global::WinRTXamlToolkit.Controls.DataVisualization.Charting.LineSeries)(target);
                    #line 25 "..\..\..\Views\POS_salestatus.xaml"
                    ((global::WinRTXamlToolkit.Controls.DataVisualization.Charting.LineSeries)element16).SelectionChanged += this.LineSeries_SelectionChanged;
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

