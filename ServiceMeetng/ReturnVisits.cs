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
    [Activity(Label = "ReturnVisits")]
    public class ReturnVisits : Activity
    {
        private List<string> mItems;
        private ListView visitsListView;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_visits);
            visitsListView = FindViewById<ListView>(Resource.Id.visitListView);


            mItems = new List<string>();
            mItems.Add("Haga revisitas");
            mItems.Add("Prepare el terreno para volver");
            mItems.Add("La preparación: esencial para hacer revisitas eficaces");
            mItems.Add("Cómo usar el nuevo folleto Buenas noticias de parte de Dios");
            mItems.Add("Reguemos la semilla a fin de que crezca");
            mItems.Add("Volver para atender el interés... ¿cuándo?");
            mItems.Add("Vuelva a visitar a todo el que dé algún indicio de interés");
            mItems.Add("Las revisitas conducen a estudios bíblicos");
            //mItems.Add("");
            //mItems.Add("");
            //mItems.Add("");
            //mItems.Add("");
            //mItems.Add("");
            //mItems.Add("");
            //mItems.Add("");
            //mItems.Add("");
            //mItems.Add("");

            ArrayAdapter<string> adapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, mItems);
            visitsListView.Adapter = adapter;
            visitsListView.ItemClick += VisitsListView_ItemClick;
        }

        private void VisitsListView_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            if (e.Position == 0)
            {
                Intent i = new Intent(this, typeof(WebActivity));
                i.PutExtra("url", "https://wol.jw.org/es/wol/d/r4/lp-s/202017405");
                this.StartActivity(i);
            }

            if (e.Position == 1)
            {
                Intent i = new Intent(this, typeof(WebActivity));
                i.PutExtra("url", "https://wol.jw.org/es/wol/d/r4/lp-s/202016012");
                this.StartActivity(i);
            }

            if (e.Position == 2)
            {
                Intent i = new Intent(this, typeof(WebActivity));
                i.PutExtra("url", "https://wol.jw.org/es/wol/d/r4/lp-s/202008247");
                this.StartActivity(i);
            }

            if (e.Position == 3)
            {
                Intent i = new Intent(this, typeof(WebActivity));
                i.PutExtra("url", "https://wol.jw.org/es/wol/d/r4/lp-s/202013087");
                this.StartActivity(i);
            }

            if (e.Position == 4)
            {
                Intent i = new Intent(this, typeof(WebActivity));
                i.PutExtra("url", "https://wol.jw.org/es/wol/d/r4/lp-s/202011401");
                this.StartActivity(i);
            }

            if (e.Position == 5)
            {
                Intent i = new Intent(this, typeof(WebActivity));
                i.PutExtra("url", "https://wol.jw.org/es/wol/d/r4/lp-s/202009401");
                this.StartActivity(i);
            }

            if (e.Position == 6)
            {
                Intent i = new Intent(this, typeof(WebActivity));
                i.PutExtra("url", "https://wol.jw.org/es/wol/d/r4/lp-s/202006442");
                this.StartActivity(i);
            }

          if (e.Position == 7)
            {
                Intent i = new Intent(this, typeof(WebActivity));
                i.PutExtra("url", "https://wol.jw.org/es/wol/d/r4/lp-s/202003131");
                this.StartActivity(i);
            }

            /*  if (e.Position == 8)
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