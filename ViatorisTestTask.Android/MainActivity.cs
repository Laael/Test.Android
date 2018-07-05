using Android.App;
using Android.Widget;
using Android.OS;
using Android.Webkit;

namespace ViatorisTestTask.Android
{
    [Activity(Label = "ViatorisTestTask.Android", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {
        int count = 1;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            WebView web = FindViewById<WebView>(Resource.Id.webView);
            web.Settings.JavaScriptEnabled = true;
            web.SetWebViewClient(new WebViewClient());
            WebViewClient client = new WebViewClient();
            web.LoadUrl("https://tero.fund");
        }
    }

    public class WebClient : WebViewClient
    {
        public override bool ShouldOverrideUrlLoading(WebView view, IWebResourceRequest request)
        {
            view.LoadUrl(request.Url.ToString());
            return true;
        }
    }
}

