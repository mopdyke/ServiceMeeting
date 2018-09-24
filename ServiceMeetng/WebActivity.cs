using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Webkit;
using Android.Widget;

namespace ServiceMeetng
{
    [Activity(Label = "WebActivity", MainLauncher =false)]
    public class WebActivity : Activity
    {
        WebView WebViewer;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            
            SetContentView(Resource.Layout.WebActivity);
                    
            WebViewer = FindViewById<WebView>(Resource.Id.WebView1);
            WebViewer.SetWebViewClient(new ExtendedWebViewClient());

            string url = Intent.GetStringExtra("url");
            WebViewer.LoadUrl(url);

        }
    

   public class ExtendedWebViewClient : WebViewClient
        {
            public override bool ShouldOverrideUrlLoading(WebView view, string url)
             {
                view.LoadUrl(url);
                return true;
            }
        }
    }
}