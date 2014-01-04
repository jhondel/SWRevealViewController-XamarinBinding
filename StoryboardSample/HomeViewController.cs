// This file has been autogenerated from a class added in the UI designer.

using System;
using MonoTouch.UIKit;
using SWRevealViewControllerBinding;

namespace SWRevealExample {
  public partial class HomeViewController : UIViewController {
    public HomeViewController(IntPtr handle)
      : base(handle) {}

    public override void ViewDidLoad() {
      base.ViewDidLoad();
      if (this.RevealViewController() == null)
        return;
      
      RevealButtonItem.Clicked += (sender, e) => this.RevealViewController().RevealToggleAnimated(true);
      View.AddGestureRecognizer(this.RevealViewController().PanGestureRecognizer);
    }
  }
}
