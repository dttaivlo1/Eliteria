﻿#pragma checksum "..\..\..\..\Views\Setting\ModifyStaffInfoView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "5ED584F9966C00AD5FD3F3F544B23999EB2E7E2C3C59DEAA59D29540B5E7A02D"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using DevExpress.Xpf.DXBinding;
using Eliteria.Views;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace Eliteria.Views {
    
    
    /// <summary>
    /// ModifyStaffInfoView
    /// </summary>
    public partial class ModifyStaffInfoView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 69 "..\..\..\..\Views\Setting\ModifyStaffInfoView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Position;
        
        #line default
        #line hidden
        
        
        #line 83 "..\..\..\..\Views\Setting\ModifyStaffInfoView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Fullname;
        
        #line default
        #line hidden
        
        
        #line 101 "..\..\..\..\Views\Setting\ModifyStaffInfoView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PhoneNum;
        
        #line default
        #line hidden
        
        
        #line 118 "..\..\..\..\Views\Setting\ModifyStaffInfoView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Email;
        
        #line default
        #line hidden
        
        
        #line 134 "..\..\..\..\Views\Setting\ModifyStaffInfoView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Address;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Eliteria;component/views/setting/modifystaffinfoview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\Setting\ModifyStaffInfoView.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 7 "..\..\..\..\Views\Setting\ModifyStaffInfoView.xaml"
            ((Eliteria.Views.ModifyStaffInfoView)(target)).Loaded += new System.Windows.RoutedEventHandler(this.UserControl_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Position = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.Fullname = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.PhoneNum = ((System.Windows.Controls.TextBox)(target));
            
            #line 100 "..\..\..\..\Views\Setting\ModifyStaffInfoView.xaml"
            this.PhoneNum.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.PhoneNum_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Email = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.Address = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
