using System;
using Foundation;
using UIKit;

namespace Demo.iOS
{
    public class CompanyTableViewSource:UITableViewSource
    {
        public UIViewController rootViewController;

        public CompanyTableViewSource()
        {
            
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            CompanyInfoTableViewCell cell = (CompanyInfoTableViewCell)tableView.DequeueReusableCell(CompanyInfoTableViewCell.Key,indexPath);
            cell.UpdateCell("北京盛安徳","汇豪国际","029-1234567");
            return cell;
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            //throw new NotImplementedException();
            return 5;
        }
        public override nint NumberOfSections(UITableView tableView)
        {
            return 1;
        }
        public override nfloat GetHeightForRow(UITableView tableView, NSIndexPath indexPath)
        {
            return 120;
        }
        public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
        {
            UIAlertController okAlertController = UIAlertController.Create("Infomation", "Company info", UIAlertControllerStyle.Alert);
            okAlertController.AddAction(UIAlertAction.Create("OK", UIAlertActionStyle.Default, null));
            rootViewController.PresentViewController(okAlertController, true, null);
        }
        //public override UITableViewCell 
    }
}
