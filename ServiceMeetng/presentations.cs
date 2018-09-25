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
    [Activity(Label = "Presentations")]
    public class presentations : Activity
    {
        private List<string> mItems;
        private ListView presentationsListView;
        protected override void OnCreate(Bundle savedInstanceState)
            {
                base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.activity_presentations);
            presentationsListView = FindViewById<ListView>(Resource.Id.presentationListView);

            mItems = new List<string>();
            mItems.Add("Inicie conversaciones que quizás le permitan predicar");
            mItems.Add("Use bien las preguntas");
            mItems.Add("Usemos los videos para enseñar la verdad");
            mItems.Add("prepare una buena introducción");
            mItems.Add("sepa cómo contestar a posibles objeciones");
            mItems.Add("Use la Biblia en el servicio del campo");
            mItems.Add("Emplee los tratados para entablar conversaciones");
            mItems.Add("Aprenda a usar jw.org");
            mItems.Add("¿Usa las tarjetas de contacto de jw.org?");
            // mItems.Add("");
            // mItems.Add("");
            //mItems.Add("");
            //mItems.Add("");
            // mItems.Add("");
            // mItems.Add("");

            ArrayAdapter<string> adapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, mItems);
            presentationsListView.Adapter = adapter;
            presentationsListView.ItemClick += Presentation_ItemClick;


        }

        private void Presentation_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            if (e.Position == 0)
            {
                Intent i = new Intent(this, typeof(WebActivity));
                i.PutExtra("url", "https://wol.jw.org/es/wol/d/r4/lp-s/202018326");
                this.StartActivity(i);
            }

            if (e.Position == 1)
            {
                Intent i = new Intent(this, typeof(WebActivity));
                i.PutExtra("url", "https://wol.jw.org/es/wol/d/r4/lp-s/202018051");
                this.StartActivity(i);
            }

            if (e.Position == 2)
            {
                Intent i = new Intent(this, typeof(WebActivity));
                i.PutExtra("url", "https://wol.jw.org/es/wol/d/r4/lp-s/202016204");
                this.StartActivity(i);
            }

            if (e.Position == 3)
            {
                Intent i = new Intent(this, typeof(WebActivity));
                i.PutExtra("url", "https://wol.jw.org/es/wol/d/r4/lp-s/202014161");
                this.StartActivity(i);
            }

            if (e.Position == 4)
            {
                Intent i = new Intent(this, typeof(WebActivity));
                i.PutExtra("url", "https://wol.jw.org/es/wol/d/r4/lp-s/202014081");
                this.StartActivity(i);
            }

            if (e.Position == 5)
            {
                Intent i = new Intent(this, typeof(WebActivity));
                i.PutExtra("url", "https://wol.jw.org/es/wol/d/r4/lp-s/201991164");
                this.StartActivity(i);
            }

            if (e.Position == 6)
            {
                Intent i = new Intent(this, typeof(WebActivity));
                i.PutExtra("url", "https://wol.jw.org/es/wol/d/r4/lp-s/202000002");
                this.StartActivity(i);
            }

            if (e.Position == 7)
             {
                 Intent i = new Intent(this, typeof(WebActivity));
                 i.PutExtra("url", "https://wol.jw.org/csf/wol/d/r464/lp-cbs/202018287");
                 this.StartActivity(i);
             }

             if (e.Position == 8)
             {
                 Intent i = new Intent(this, typeof(WebActivity));
                 i.PutExtra("url", "https://wol.jw.org/es/wol/d/r4/lp-s/202016374");
                 this.StartActivity(i);
             }

            /* if (e.Position == 9)
             {
                 Intent i = new Intent(this, typeof(WebActivity));
                 i.PutExtra("url", "https://jw.org/en");
                 this.StartActivity(i);
             }

             if (e.Position == 10)
             {
                 Intent i = new Intent(this, typeof(WebActivity));
                 i.PutExtra("url", "https://jw.org/en");
                 this.StartActivity(i);
             }

             if (e.Position == 11)
             {
                 Intent i = new Intent(this, typeof(WebActivity));
                 i.PutExtra("url", "https://jw.org/en");
                 this.StartActivity(i);
             }

             if (e.Position == 12)
             {
                 Intent i = new Intent(this, typeof(WebActivity));
                 i.PutExtra("url", "https://jw.org/en");
                 this.StartActivity(i);
             }

             if (e.Position == 13)
             {
                 Intent i = new Intent(this, typeof(WebActivity));
                 i.PutExtra("url", "https://jw.org/en");
                 this.StartActivity(i);
             }

             if (e.Position == 14)
            {
                 Intent i = new Intent(this, typeof(WebActivity));
                 i.PutExtra("url", "https://wol.jw.org/es/wol/d/r4/lp-s/1102001065");
                 this.StartActivity(i);
             }*/
        }
    }
}