﻿#pragma checksum "..\..\..\..\View\TableMenu\EditTableWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "051FF0D1CDA4833355D5D0EEB3323393A835EABF7149E19702E022FCE2527B63"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using SimplyDB.TableMenu;
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


namespace SimplyDB.TableMenu {
    
    
    /// <summary>
    /// EditTableWindow
    /// </summary>
    public partial class EditTableWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 23 "..\..\..\..\View\TableMenu\EditTableWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tableNameTextBox;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\..\View\TableMenu\EditTableWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button tableNameUpdateButton;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\..\View\TableMenu\EditTableWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid editTableDataGrid;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\..\View\TableMenu\EditTableWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button TableEditConfirmButton;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\..\View\TableMenu\EditTableWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button TableEditCancelButton;
        
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
            System.Uri resourceLocater = new System.Uri("/SimplyDB;component/view/tablemenu/edittablewindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\View\TableMenu\EditTableWindow.xaml"
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
            this.tableNameTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.tableNameUpdateButton = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\..\..\View\TableMenu\EditTableWindow.xaml"
            this.tableNameUpdateButton.Click += new System.Windows.RoutedEventHandler(this.tableNameUpdateButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.editTableDataGrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 28 "..\..\..\..\View\TableMenu\EditTableWindow.xaml"
            this.editTableDataGrid.PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.editTableDataGrid_PreviewKeyDown);
            
            #line default
            #line hidden
            
            #line 28 "..\..\..\..\View\TableMenu\EditTableWindow.xaml"
            this.editTableDataGrid.LoadingRow += new System.EventHandler<System.Windows.Controls.DataGridRowEventArgs>(this.editTableDataGrid_LoadingRow);
            
            #line default
            #line hidden
            return;
            case 4:
            this.TableEditConfirmButton = ((System.Windows.Controls.Button)(target));
            
            #line 43 "..\..\..\..\View\TableMenu\EditTableWindow.xaml"
            this.TableEditConfirmButton.Click += new System.Windows.RoutedEventHandler(this.TableEditConfirmButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.TableEditCancelButton = ((System.Windows.Controls.Button)(target));
            
            #line 44 "..\..\..\..\View\TableMenu\EditTableWindow.xaml"
            this.TableEditCancelButton.Click += new System.Windows.RoutedEventHandler(this.TableEditCancelButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
