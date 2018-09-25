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
    [Activity(Label = "studies")]
    public class studies : Activity
    {

        private List<string> mItems;
        private ListView studiesListView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.activity_studies);
            studiesListView = FindViewById<ListView>(Resource.Id.studyListView);

            mItems = new List<string>();
            mItems.Add("Una labor muy gratificante");
            mItems.Add("Centrémonos en hacer discípulos");
            mItems.Add("El atractivo diseño de los nuevos tratados");
            mItems.Add("Un nuevo video para comenzar estudios bíblicos");
            mItems.Add("¿Ha demostrado en la primera visita cómo se realiza el estudio bíblico?");
            mItems.Add("Iniciemos estudios bíblicos con quienes aceptaron las revistas");
            mItems.Add("Cómo iniciar estudios bíblicos en la puerta y por teléfono");
            mItems.Add("Dirijamos estudios bíblicos progresivos en la puerta y por teléfono");
            //mItems.Add("");
            //mItems.Add("");
            // mItems.Add("");
            // mItems.Add("");
            // mItems.Add("");
            // mItems.Add("");
            // mItems.Add("");
            // mItems.Add("");

            ArrayAdapter<string> adapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, mItems);
            studiesListView.Adapter = adapter;
            studiesListView.ItemClick += StudiesListView_ItemClick;
        }

        private void StudiesListView_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            if (e.Position == 0)
            {
                Intent i = new Intent(this, typeof(WebActivity));
                i.PutExtra("url", "https://wol.jw.org/es/wol/d/r4/lp-s/202011002");
                this.StartActivity(i);
            }

            if (e.Position == 1)
            {
                Intent i = new Intent(this, typeof(WebActivity));
                i.PutExtra("url", "https://wol.jw.org/es/wol/d/r4/lp-s/202015242");
                this.StartActivity(i);
            }

            if (e.Position == 2)
            {
                Intent i = new Intent(this, typeof(WebActivity));
                i.PutExtra("url", "https://wol.jw.org/es/wol/d/r4/lp-s/202014130");
                this.StartActivity(i);
            }

            if (e.Position == 3)
            {
                Intent i = new Intent(this, typeof(WebActivity));
                i.PutExtra("url", "https://wol.jw.org/es/wol/d/r4/lp-s/202014131");
                this.StartActivity(i);
            }

            if (e.Position == 4)
            {
                Intent i = new Intent(this, typeof(WebActivity));
                i.PutExtra("url", "https://wol.jw.org/es/wol/d/r4/lp-s/202010167");
                this.StartActivity(i);
            }

            if (e.Position == 5)
            {
                Intent i = new Intent(this, typeof(WebActivity));
                i.PutExtra("url", "https://wol.jw.org/es/wol/d/r4/lp-s/202007285");
                this.StartActivity(i);
            }

            if (e.Position == 6)
            {
                Intent i = new Intent(this, typeof(WebActivity));
                i.PutExtra("url", "https://wol.jw.org/es/wol/d/r4/lp-s/202005293");
                this.StartActivity(i);
            }

            if (e.Position == 7)
             {
                 Intent i = new Intent(this, typeof(WebActivity));
                 i.PutExtra("url", "https://wol.jw.org/es/wol/d/r4/lp-s/202006125");
                 this.StartActivity(i);
             }

            /* if (e.Position == 8)
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