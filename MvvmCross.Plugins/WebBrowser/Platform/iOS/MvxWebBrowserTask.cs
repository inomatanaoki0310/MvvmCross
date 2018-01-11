﻿// MvxWebBrowserTask.cs
// (c) Copyright Cirrious Ltd. http://www.cirrious.com
// MvvmCross is licensed using Microsoft Public License (Ms-PL)
// Contributions and inspirations noted in readme.md and license.txt
//
// Project Lead - Stuart Lodge, @slodge, me@slodge.com

using Foundation;
using MvvmCross.Platform.iOS.Platform;

namespace MvvmCross.Plugins.WebBrowser.iOS
{
    [Preserve(AllMembers = true)]
	public class MvxWebBrowserTask : MvxIosTask, IMvxWebBrowserTask
    {
        public void ShowWebPage(string url)
        {
            var nsurl = new NSUrl(url);
            DoUrlOpen(nsurl);
        }
    }
}