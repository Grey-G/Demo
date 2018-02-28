// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace Demo.iOS
{
    [Register ("CompanyInfoTableViewCell")]
    partial class CompanyInfoTableViewCell
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel address { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView icon { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel name { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel phone { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (address != null) {
                address.Dispose ();
                address = null;
            }

            if (icon != null) {
                icon.Dispose ();
                icon = null;
            }

            if (name != null) {
                name.Dispose ();
                name = null;
            }

            if (phone != null) {
                phone.Dispose ();
                phone = null;
            }
        }
    }
}