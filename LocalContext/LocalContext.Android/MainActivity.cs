using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using LocalContext.Droid.Platform;
using LocalContext.Platform;

namespace LocalContext.Droid
{
    [Activity(Label = "LocalContext", Icon = "@drawable/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        internal static MainActivity Instance { get; private set; }
        protected override void OnCreate(Bundle bundle)
        {

            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);
            Instance = this;
            VersionHelper.Init(Instance); // both options are possible when we have single activity

            Xamarin.Forms.DependencyService.Register<IVersionHelper, VersionHelper>();
            LoadApplication(new App());
        }
    }
}

