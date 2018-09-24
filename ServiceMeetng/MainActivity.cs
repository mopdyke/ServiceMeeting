using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using System.Collections.Generic;
using Android.Content;
using System;
using Android.Webkit;

namespace ServiceMeetng
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : Activity
    {
        private List<string> mItems;
        private ListView mainListView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            mainListView = FindViewById<ListView>(Resource.Id.mainListView);

            mItems = new List<string>();
            mItems.Add("Reuniones para el Servicio de campo");
            mItems.Add("Trabajando de casa en casa");
            mItems.Add("Presentaciones");
            mItems.Add("Uso de las revistas");
            mItems.Add("Revisitas eficaces");
            mItems.Add("Comenzando estudios biblicos");
            mItems.Add("Dirigir estudios progresivos");
            mItems.Add("Territorio de negocios");
            mItems.Add("Predicacion con los exhibidores");
            mItems.Add("Prediacion informal");
            mItems.Add("Predicacion por telefono");
            mItems.Add("Predicacion por carta");
            mItems.Add("Libro Razonamiento");

            ArrayAdapter<string> adapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, mItems);
            mainListView.Adapter = adapter;
            mainListView.ItemClick += MainListView_ItemClick;
        }

        private void MainListView_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
                   
        {
            
            if ( e.Position == 0)
            {
                Intent i = new Intent(this, typeof(WebActivity));
                i.PutExtra("url", "https://wol.jw.org/es/wol/d/r4/lp-s/202015086");
                this.StartActivity(i);
            }

            if (e.Position == 1)
            {
                Intent i = new Intent(this, typeof(House));                
                this.StartActivity(i);
            }

            if (e.Position == 2)
            {
                Intent i = new Intent(this, typeof(presentations));
                this.StartActivity(i);
            }

            if (e.Position == 3)
            {
                Intent i = new Intent(this, typeof(magazines));
                this.StartActivity(i);
            }

            if (e.Position == 4)
            {
                Intent i = new Intent(this, typeof(ReturnVisits));
                this.StartActivity(i);
            }

            if (e.Position == 5)
            {
                Intent i = new Intent(this, typeof(studies));
                this.StartActivity(i);
            }

            if (e.Position == 6)
            {
                Intent i = new Intent(this, typeof(progressive));
                this.StartActivity(i);
            }

            if (e.Position == 7)
            {
                Intent i = new Intent(this, typeof(business));
                this.StartActivity(i);
            }

            if (e.Position == 8)
            {
                Intent i = new Intent(this, typeof(carts));
                this.StartActivity(i);
            }

            if (e.Position == 9)
            {
                Intent i = new Intent(this, typeof(informal));
                this.StartActivity(i);
            }

            if (e.Position == 10)
            {
                Intent i = new Intent(this, typeof(phone));
                this.StartActivity(i);
            }

            if (e.Position == 11)
            {
                Intent i = new Intent(this, typeof(WebActivity));
                i.PutExtra("url", "https://wol.jw.org/es/wol/d/r4/lp-s/1102001065");
                this.StartActivity(i);
            }

            if (e.Position == 12)
            {
                Intent i = new Intent(this, typeof(WebActivity));
                i.PutExtra("url", "https://wol.jw.org/es/wol/lv/r4/lp-s/0/47461");
                this.StartActivity(i);
            }
        }

    }

}