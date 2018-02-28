using Foundation;
using System;
using CoreGraphics;
using UIKit;

namespace Demo.iOS
{
    public partial class CompayInfoViewControll : UIViewController
    {
        public CompayInfoViewControll (IntPtr handle) : base (handle)
        {

        }
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            CompanyTableView.RegisterNibForCellReuse(CompanyInfoTableViewCell.Nib, CompanyInfoTableViewCell.Key);
            var source = new CompanyTableViewSource();
            CompanyTableView.Source = source;
            source.rootViewController = this;
           
        }
        public void decribe()
        {
            var alertController = UIAlertController.Create("title", "description", UIAlertControllerStyle.Alert);
            alertController.AddAction(UIAlertAction.Create("Cancel", UIAlertActionStyle.Cancel, alert => Console.Write("123")));
            PresentViewController(alertController, true, null);
        }
    }
}