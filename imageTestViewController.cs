﻿using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace imageTest
{
	public partial class imageTestViewController : UIViewController
	{
		public imageTestViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			
			// Perform any additional setup after loading the view, typically from a nib.
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}
	}
}

