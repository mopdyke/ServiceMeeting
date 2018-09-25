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
    [Activity(Label = "informal")]
    public class informal : Activity
    {
        private List<string> mItems;
        private ListView informallyListView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.activity_informal);
            informallyListView = FindViewById<ListView>(Resource.Id.informalListView);

            mItems = new List<string>();
            mItems.Add("¿Predicar informalmente? ¡Claro que usted puede!");
            mItems.Add("¿Listos para predicar informalmente?");
            mItems.Add("¿Participará en la testificación informal este verano?");
            mItems.Add("¿Usa las tarjetas de contacto de jw.org?");
            mItems.Add("Presentando las buenas nuevas... mediante la testificación informal");
            mItems.Add("Seamos diligentes “dando testimonio cabal”");
            /* mItems.Add("");
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
            informallyListView.Adapter = adapter;
            informallyListView.ItemClick += InformallyListView_ItemClick;
        }

        private void InformallyListView_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            if (e.Position == 0)
            {
                Intent i = new Intent(this, typeof(WebActivity));
                i.PutExtra("url", "https://wol.jw.org/es/wol/d/r4/lp-s/202010286");
                this.StartActivity(i);
            }

            if (e.Position == 1)
            {
                Intent i = new Intent(this, typeof(WebActivity));
                i.PutExtra("url", "https://wol.jw.org/es/wol/d/r4/lp-s/202009363");
                this.StartActivity(i);
            }

            if (e.Position == 2)
            {
                Intent i = new Intent(this, typeof(WebActivity));
                i.PutExtra("url", "https://wol.jw.org/es/wol/d/r4/lp-s/201992201");
                this.StartActivity(i);
            }

            if (e.Position == 3)
             {
                 Intent i = new Intent(this, typeof(WebActivity));
                 i.PutExtra("url", "https://wol.jw.org/es/wol/d/r4/lp-s/202016374");
                 this.StartActivity(i);
             }

             if (e.Position == 4)
             {
                 Intent i = new Intent(this, typeof(WebActivity));
                 i.PutExtra("url", "https://wol.jw.org/es/wol/d/r4/lp-s/201987329");
                 this.StartActivity(i);
             }

             if (e.Position == 5)
             {
                 Intent i = new Intent(this, typeof(WebActivity));
                 i.PutExtra("url", "https://wol.jw.org/es/wol/d/r4/lp-s/202003208");
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