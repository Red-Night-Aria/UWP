﻿#pragma checksum "D:\git\新建文件夹\UWP\超市管理系统\manageCMD.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "890C41D5A742FD20AA9F4744A2E93938"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace 超市管理系统
{
    partial class manageCMD : 
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
                    this.search = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 54 "..\..\..\manageCMD.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.search).Click += this.search_Click;
                    #line default
                }
                break;
            case 2:
                {
                    this.editCMD = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 55 "..\..\..\manageCMD.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.editCMD).Click += this.editCMD_Click;
                    #line default
                }
                break;
            case 3:
                {
                    this.deleteAllCMD = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 56 "..\..\..\manageCMD.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.deleteAllCMD).Click += this.deleteAllCMD_Click;
                    #line default
                }
                break;
            case 4:
                {
                    this.backButton2 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 57 "..\..\..\manageCMD.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.backButton2).Click += this.backButton_Click;
                    #line default
                }
                break;
            case 5:
                {
                    this.numbersTextBox = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 6:
                {
                    this.priceTextBox = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 7:
                {
                    this.incomePriceTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 8:
                {
                    this.nameComboBox = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                }
                break;
            case 9:
                {
                    this.backButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 16 "..\..\..\manageCMD.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.backButton).Click += this.backButton_Click;
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

