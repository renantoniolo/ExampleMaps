using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;

namespace ExampleMaps.iOS
{
	[Register("AppDelegate")]
	public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
	{
		public override bool FinishedLaunching(UIApplication app, NSDictionary options)
		{
			
			global::Xamarin.Forms.Forms.Init();
			Xamarin.FormsGoogleMaps.Init("AIzaSyADbk0dUoSM3fDm8K34nP4P_bMjCvUng68");

			LoadApplication(new App());

			return base.FinishedLaunching(app, options);


		}
	}
}
