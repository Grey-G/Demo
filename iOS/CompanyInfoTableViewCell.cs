using System;

using Foundation;
using UIKit;

namespace Demo.iOS
{
    public partial class CompanyInfoTableViewCell : UITableViewCell
    {
        public static readonly NSString Key = new NSString("CompanyInfoTableViewCell");
        public static readonly UINib Nib;

        static CompanyInfoTableViewCell()
        {
            Nib = UINib.FromName("CompanyInfoTableViewCell", NSBundle.MainBundle);
        }

        protected CompanyInfoTableViewCell(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public void UpdateCell(string names,string addresses,string phones)
        {
            this.name.Text = names;
            this.address.Text = addresses;
            this.phone.Text = phones;
        }
    }
}
