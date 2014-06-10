// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using System;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.CodeDom.Compiler;

namespace KidSoft
{
	[Register ("KidSoftViewController")]
	partial class KidSoftViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton btnEntry { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField txtPassword { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField txtUser { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (btnEntry != null) {
				btnEntry.Dispose ();
				btnEntry = null;
			}
			if (txtPassword != null) {
				txtPassword.Dispose ();
				txtPassword = null;
			}
			if (txtUser != null) {
				txtUser.Dispose ();
				txtUser = null;
			}
		}
	}
}
