﻿#pragma checksum "D:\编程文件\超市管理系统\超市管理系统\manageAcount1.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "3F68D6CF7E0354014E722C58FC7F269E"
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
    partial class manageAcount1 : 
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
                    this.pivot = (global::Windows.UI.Xaml.Controls.Pivot)(target);
                }
                break;
            case 2:
                {
                    this.editButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 84 "..\..\..\manageAcount1.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.editButton).Click += this.editButton_Click;
                    #line default
                }
                break;
            case 3:
                {
                    this.backOutButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 85 "..\..\..\manageAcount1.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.backOutButton).Click += this.backButton_Click;
                    #line default
                }
                break;
            case 4:
                {
                    this.newPasswordTextBox = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 5:
                {
                    this.newPasswordAgainTextBox = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 6:
                {
                    this.oldPasswordTextBox = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 7:
                {
                    this.deleteAcount = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 60 "..\..\..\manageAcount1.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.deleteAcount).Click += this.deleteAcount_Click;
                    #line default
                }
                break;
            case 8:
                {
                    this.back = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 61 "..\..\..\manageAcount1.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.back).Click += this.backout_Click;
                    #line default
                }
                break;
            case 9:
                {
                    this.nameComboBox = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                }
                break;
            case 10:
                {
                    this.addNewAcount = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 42 "..\..\..\manageAcount1.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.addNewAcount).Click += this.addNewAcount_Click;
                    #line default
                }
                break;
            case 11:
                {
                    this.backout = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 43 "..\..\..\manageAcount1.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.backout).Click += this.backout_Click;
                    #line default
                }
                break;
            case 12:
                {
                    this.passwordTextBox = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 13:
                {
                    this.loginNameTextBox = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 14:
                {
                    this.nameTextBox = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 15:
                {
                    this.backButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 16 "..\..\..\manageAcount1.xaml"
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

