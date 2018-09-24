using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace ServiceMeetng
{
    [Activity(Label = "carts")]
    public class carts : Activity
    {
        private List<string> mItems;
        private ListView cartsListView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.activity_carts);
             cartsListView= FindViewById<ListView>(Resource.Id.cartListView);

            mItems = new List<string>();
            mItems.Add("Cómo predicar con los exhibidores de publicaciones");
            mItems.Add("Nuevos programas de predicación pública");
            mItems.Add("La predicación pública es ahora más emocionante");
            /*mItems.Add("");
            mItems.Add("");
            mItems.Add("");
            mItems.Add("");
            mItems.Add("");
            mItems.Add("");
            mItems.Add("");
            mItems.Add("");
            mItems.Add("");
            mItems.Add("");
            mItems.Add("");
            mItems.Add("");
            mItems.Add("");*/

            ArrayAdapter<string> adapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, mItems);
            cartsListView.Adapter = adapter;
            cartsListView.ItemClick += cartsListView_ItemClick;
        }

        private void cartsListView_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            if (e.Position == 0)
            {
                Intent i = new Intent(this, typeof(WebActivity));
                i.PutExtra("url", "https://wol.jw.org/es/wol/d/r4/lp-s/202015126");
                this.StartActivity(i);
            }

            if (e.Position == 1)
            {
                Intent i = new Intent(this, typeof(WebActivity));
                i.PutExtra("url", "https://wol.jw.org/es/wol/d/r4/lp-s/202013245");
                this.StartActivity(i);
            }

            if (e.Position == 2)
            {
                Intent i = new Intent(this, typeof(WebActivity));
                i.PutExtra("url", "https://wol.jw.org/es/wol/d/r4/lp-s/202014403");
                this.StartActivity(i);
            }

            /*if (e.Position == 3)
            {
                Intent i = new Intent(this, typeof(WebActivity));
                i.PutExtra("url", "");
                this.StartActivity(i);
            }

            if (e.Position == 4)
            {
                Intent i = new Intent(this, typeof(WebActivity));
                i.PutExtra("url", "");
                this.StartActivity(i);
            }

            if (e.Position == 5)
            {
                Intent i = new Intent(this, typeof(WebActivity));
                i.PutExtra("url", "");
                this.StartActivity(i);
            }

            if (e.Position == 6)
            {
                Intent i = new Intent(this, typeof(WebActivity));
                i.PutExtra("url", "");
                this.StartActivity(i);
            }

            if (e.Position == 7)
            {
                Intent i = new Intent(this, typeof(WebActivity));
                i.PutExtra("url", "");
                this.StartActivity(i);
            }

            if (e.Position == 8)
            {
                Intent i = new Intent(this, typeof(WebActivity));
                i.PutExtra("url", "");
                this.StartActivity(i);
            }

            if (e.Position == 9)
            {
                Intent i = new Intent(this, typeof(WebActivity));
                i.PutExtra("url", "");
                this.StartActivity(i);
            }

            if (e.Position == 10)
            {
                Intent i = new Intent(this, typeof(WebActivity));
                i.PutExtra("url", "");
                this.StartActivity(i);
            }

            if (e.Position == 11)
            {
                Intent i = new Intent(this, typeof(WebActivity));
                i.PutExtra("url", "");
                this.StartActivity(i);
            }

            if (e.Position == 12)
            {
                Intent i = new Intent(this, typeof(WebActivity));
                i.PutExtra("url", "");
                this.StartActivity(i);
            }

            if (e.Position == 13)
            {
                Intent i = new Intent(this, typeof(WebActivity));
                i.PutExtra("url", "");
                this.StartActivity(i);
            }

            if (e.Position == 14)
            {
                Intent i = new Intent(this, typeof(WebActivity));
                i.PutExtra("url", "");
                this.StartActivity(i);
            }*/
        }
    }
}