#pragma checksum "..\..\..\Pages\ProductDetailPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "7C0A5646B830E71E4F819CC4861E9CF43BE2C345D8831CB207DAFCFB017EC144"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Lopushok.Pages;
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


namespace Lopushok.Pages {
    
    
    /// <summary>
    /// ProductDetailPage
    /// </summary>
    public partial class ProductDetailPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\..\Pages\ProductDetailPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid ProductInfoGrid;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\Pages\ProductDetailPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button MinusBtn;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\Pages\ProductDetailPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button PlusBtn;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\..\Pages\ProductDetailPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CreateBtn;
        
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
            System.Uri resourceLocater = new System.Uri("/Lopushok;component/pages/productdetailpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\ProductDetailPage.xaml"
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
            this.ProductInfoGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.MinusBtn = ((System.Windows.Controls.Button)(target));
            
            #line 54 "..\..\..\Pages\ProductDetailPage.xaml"
            this.MinusBtn.Click += new System.Windows.RoutedEventHandler(this.MinusBtn_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.PlusBtn = ((System.Windows.Controls.Button)(target));
            
            #line 58 "..\..\..\Pages\ProductDetailPage.xaml"
            this.PlusBtn.Click += new System.Windows.RoutedEventHandler(this.PlusBtn_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.CreateBtn = ((System.Windows.Controls.Button)(target));
            
            #line 78 "..\..\..\Pages\ProductDetailPage.xaml"
            this.CreateBtn.Click += new System.Windows.RoutedEventHandler(this.CreateBtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

