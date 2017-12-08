using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LocalContext.Platform;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace LocalContext.Droid.Platform
{
    public class VersionHelper : IVersionHelper
    {
        static Context _context;
        public static void Init(Context context)
        {
            _context = context;
        }

        public string GetVersionNumber()
        {
            var versionNumber = string.Empty;
            if (_context != null)
            {
                versionNumber = _context.PackageManager.GetPackageInfo(_context.PackageName, 0).VersionName;
            }
            return versionNumber;
        }
    }
}