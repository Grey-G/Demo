// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace Demo.iOS
{
    [Register ("CompayInfoViewControll")]
    partial class CompayInfoViewControll
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITableView CompanyTableView { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (CompanyTableView != null) {
                CompanyTableView.Dispose ();
                CompanyTableView = null;
            }
        }
    }
}