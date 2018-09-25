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
    [Activity(Label = "progressive")]
    public class progressive : Activity
    {
        private List<string> mItems;
        private ListView progressiveListView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.activity_progressive);
            progressiveListView = FindViewById<ListView>(Resource.Id.progressListView);

            mItems = new List<string>();
            mItems.Add("1a parte: ¿Qué es un estudio bíblico?");
            mItems.Add("2a parte: Preparación para el estudio");
            mItems.Add("3a parte: Uso eficaz de las Escrituras");
            mItems.Add("4a parte: Cómo enseñar al estudiante a prepararse");
            mItems.Add("5a parte: Cuánta información estudiar");
            mItems.Add("6a parte: Cuando el estudiante plantea una pregunta");
            mItems.Add("7a parte: La oración en el estudio");
            mItems.Add("8a parte: Dirijamos a los estudiantes a la organización");
            mItems.Add("9a parte: Cómo preparar al estudiante para la predicación informal");
            mItems.Add("10a parte: Cómo preparar al estudiante para la predicación de casa en casa");
            mItems.Add("11a parte: Cómo enseñar al estudiante a hacer revisitas");
            mItems.Add("12a parte: Cómo ayudar al estudiante a comenzar y dirigir estudios de la Biblia");
            mItems.Add("Para Guardar: Dirijamos estudios bíblicos progresivos");
            //mItems.Add("");
            //mItems.Add("");
            //mItems.Add("");

            ArrayAdapter<string> adapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, mItems);
            progressiveListView.Adapter = adapter;
            progressiveListView.ItemClick += ProgressiveListView_ItemClick;

        }

        private void ProgressiveListView_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            if (e.Position == 0)
            {
                Intent i = new Intent(this, typeof(WebActivity));
                i.PutExtra("url", "https://wol.jw.org/es/wol/d/r4/lp-s/202004241");
                this.StartActivity(i);
            }

            if (e.Position == 1)
            {
                Intent i = new Intent(this, typeof(WebActivity));
                i.PutExtra("url", "https://wol.jw.org/es/wol/d/r4/lp-s/202004282");
                this.StartActivity(i);
            }

            if (e.Position == 2)
            {
                Intent i = new Intent(this, typeof(WebActivity));
                i.PutExtra("url", "https://wol.jw.org/es/wol/d/r4/lp-s/202004406");
                this.StartActivity(i);
            }

            if (e.Position == 3)
            {
                Intent i = new Intent(this, typeof(WebActivity));
                i.PutExtra("url", "https://wol.jw.org/es/wol/d/r4/lp-s/202004442");
                this.StartActivity(i);
            }

            if (e.Position == 4)
            {
                Intent i = new Intent(this, typeof(WebActivity));
                i.PutExtra("url", "https://wol.jw.org/es/wol/d/r4/lp-s/202005001");
                this.StartActivity(i);
            }

            if (e.Position == 5)
            {
                Intent i = new Intent(this, typeof(WebActivity));
                i.PutExtra("url", "https://wol.jw.org/es/wol/d/r4/lp-s/202005046");
                this.StartActivity(i);
            }

            if (e.Position == 6)
            {
                Intent i = new Intent(this, typeof(WebActivity));
                i.PutExtra("url", "https://wol.jw.org/es/wol/d/r4/lp-s/202005085");
                this.StartActivity(i);
            }

            if (e.Position == 7)
            {
                Intent i = new Intent(this, typeof(WebActivity));
                i.PutExtra("url", "https://wol.jw.org/es/wol/d/r4/lp-s/202005129");
                this.StartActivity(i);
            }

            if (e.Position == 8)
            {
                Intent i = new Intent(this, typeof(WebActivity));
                i.PutExtra("url", "https://wol.jw.org/es/wol/d/r4/lp-s/202005161");
                this.StartActivity(i);
            }

            if (e.Position == 9)
            {
                Intent i = new Intent(this, typeof(WebActivity));
                i.PutExtra("url", "https://wol.jw.org/es/wol/d/r4/lp-s/202005202");
                this.StartActivity(i);
            }

            if (e.Position == 10)
            {
                Intent i = new Intent(this, typeof(WebActivity));
                i.PutExtra("url", "https://wol.jw.org/es/wol/d/r4/lp-s/202005241");
                this.StartActivity(i);
            }

            if (e.Position == 11)
            {
                Intent i = new Intent(this, typeof(WebActivity));
                i.PutExtra("url", "https://wol.jw.org/es/wol/d/r4/lp-s/202005282");
                this.StartActivity(i);
            }

            if (e.Position == 12)
            {
                Intent i = new Intent(this, typeof(WebActivity));
                i.PutExtra("url", "https://wol.jw.org/es/wol/d/r4/lp-s/202005324");
                this.StartActivity(i);
            }

            /*if (e.Position == 13)
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