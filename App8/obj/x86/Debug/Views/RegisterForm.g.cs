﻿#pragma checksum "C:\Users\Dang Dinh Si\source\repos\App8\App8\Views\RegisterForm.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "77813F15529E02E207A79907D9FB1D62"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace App8.Views
{
    partial class RegisterFrom : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // Views\RegisterForm.xaml line 37
                {
                    this.MyAvatar = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 3: // Views\RegisterForm.xaml line 39
                {
                    global::Windows.UI.Xaml.Controls.Button element3 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element3).Click += this.Choose_Image;
                }
                break;
            case 4: // Views\RegisterForm.xaml line 41
                {
                    global::Windows.UI.Xaml.Controls.RadioButton element4 = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                    ((global::Windows.UI.Xaml.Controls.RadioButton)element4).Checked += this.Select_Gender;
                }
                break;
            case 5: // Views\RegisterForm.xaml line 42
                {
                    global::Windows.UI.Xaml.Controls.RadioButton element5 = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                    ((global::Windows.UI.Xaml.Controls.RadioButton)element5).Checked += this.Select_Gender;
                }
                break;
            case 6: // Views\RegisterForm.xaml line 44
                {
                    global::Windows.UI.Xaml.Controls.RadioButton element6 = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                    ((global::Windows.UI.Xaml.Controls.RadioButton)element6).Checked += this.Select_Gender;
                }
                break;
            case 7: // Views\RegisterForm.xaml line 47
                {
                    this.BirthDay = (global::Windows.UI.Xaml.Controls.CalendarDatePicker)(target);
                    ((global::Windows.UI.Xaml.Controls.CalendarDatePicker)this.BirthDay).DateChanged += this.Change_Birthday;
                }
                break;
            case 8: // Views\RegisterForm.xaml line 23
                {
                    this.FirstName = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 9: // Views\RegisterForm.xaml line 24
                {
                    this.LastName = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 10: // Views\RegisterForm.xaml line 25
                {
                    this.Password = (global::Windows.UI.Xaml.Controls.PasswordBox)(target);
                }
                break;
            case 11: // Views\RegisterForm.xaml line 26
                {
                    this.Address = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 12: // Views\RegisterForm.xaml line 27
                {
                    this.Email = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 13: // Views\RegisterForm.xaml line 28
                {
                    this.Phone = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 14: // Views\RegisterForm.xaml line 29
                {
                    this.ImageUrl = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 15: // Views\RegisterForm.xaml line 31
                {
                    this.BtnSignup = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.BtnSignup).Click += this.Handle_Signup;
                }
                break;
            case 16: // Views\RegisterForm.xaml line 12
                {
                    global::Windows.UI.Xaml.Controls.AppBarButton element16 = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)element16).Click += this.goHome;
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}
