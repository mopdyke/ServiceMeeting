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

namespace ServiceMeeting
{
    [Activity(Label = "business")]
    public class business : Activity
    {
        private List<string> mItems;
        private ListView businessesListView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.activity_business);
            businessesListView = FindViewById<ListView>(Resource.Id.businessListView);

            mItems = new List<string>();
            mItems.Add("Mejore sus habilidades en el ministerio: en territorios de negocios");
            mItems.Add("La predicación en territorio de negocios");
            mItems.Add("Presentando las buenas nuevas... al testificar denodadamente en territorio de negocios");
            mItems.Add("Presentando las buenas nuevas... en los territorios de negocios");
            mItems.Add("Territorio desafiante, pero remunerador");
            mItems.Add("¿Usa las tarjetas de contacto de jw.org?");
            /*mItems.Add("");
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
            businessesListView.Adapter = adapter;
            businessesListView.ItemClick += BusinessesListView_ItemClick;

        }

        private void BusinessesListView_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            if (e.Position == 0)
            {
                Intent i = new Intent(this, typeof(WebActivity));
                i.PutExtra("url", "https://wol.jw.org/es/wol/d/r4/lp-s/202015322");
                this.StartActivity(i);
            }

            if (e.Position == 1)
            {
                Intent i = new Intent(this, typeof(WebActivity));
                i.PutExtra("url", "https://wol.jw.org/es/wol/d/r4/lp-s/202004245");
                this.StartActivity(i);
            }

            if (e.Position == 2)
            {
                Intent i = new Intent(this, typeof(WebActivity));
                i.PutExtra("url", "https://wol.jw.org/es/wol/d/r4/lp-s/201989328");
                this.StartActivity(i);
            }

            if (e.Position == 3)
            {
                Intent i = new Intent(this, typeof(WebActivity));
                i.PutExtra("url", "https://wol.jw.org/es/wol/d/r4/lp-s/201982409");
                this.StartActivity(i);
            }

            if (e.Position == 4)
            {
                Intent i = new Intent(this, typeof(WebActivity));
                i.PutExtra("url", "https://wol.jw.org/es/wol/d/r4/lp-s/201973205");
                this.StartActivity(i);
            }

            if (e.Position == 5)
            {
                Intent i = new Intent(this, typeof(WebActivity));
                i.PutExtra("url", "https://wol.jw.org/es/wol/d/r4/lp-s/202016374");
                this.StartActivity(i);
            }

            /*if (e.Position == 6)
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