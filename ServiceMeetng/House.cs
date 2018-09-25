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
    [Activity(Label = "House")]
    public class House : Activity
    {
        private List<string> mItems;
        private ListView houseListView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.activity_house);
            houseListView = FindViewById<ListView>(Resource.Id.houseListview);
            mItems = new List<string>();
            mItems.Add("Contacte con todas las personas");
            mItems.Add("En busca de los merecedores");
            mItems.Add("Lleve un registro de las personas interesadas");
            mItems.Add("Aprenda a responder a una persona furiosa");
            mItems.Add("Ayude a su compañero");
            mItems.Add("Cómo predicar a alguien que habla otro idioma");
            mItems.Add("Muestre interés por las personas");
            mItems.Add("Sepa cómo contestar a posibles objeciones");
            mItems.Add("Predique eficazmente a través del interfono");
            mItems.Add("Hable del Reino con valor y convicción");
            mItems.Add("Con discernimiento");

            ArrayAdapter<string> adapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, mItems);
            houseListView.Adapter = adapter;
            houseListView.ItemClick += HouseListView_ItemClick;


        }

        private void HouseListView_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            if (e.Position == 0)
            {
                Intent i = new Intent(this, typeof(WebActivity));
                i.PutExtra("url", "https://wol.jw.org/es/wol/d/r4/lp-s/202017446");
                this.StartActivity(i);
            }

            if (e.Position == 1)
            {
                Intent i = new Intent(this, typeof(WebActivity));
                i.PutExtra("url", "https://wol.jw.org/es/wol/d/r4/lp-s/202003442");
                this.StartActivity(i);
            }

            if (e.Position == 2)
            {
                Intent i = new Intent(this, typeof(WebActivity));
                i.PutExtra("url", "https://wol.jw.org/es/wol/d/r4/lp-s/202014042");
                this.StartActivity(i);
            }

            if (e.Position == 3)
            {
                Intent i = new Intent(this, typeof(WebActivity));
                i.PutExtra("url", "https://wol.jw.org/es/wol/d/r4/lp-s/202015003");
                this.StartActivity(i);
            }

            if (e.Position == 4)
            {
                Intent i = new Intent(this, typeof(WebActivity));
                i.PutExtra("url", "https://wol.jw.org/es/wol/d/r4/lp-s/202014122");
                this.StartActivity(i);
            }

            if (e.Position == 5)
            {
                Intent i = new Intent(this, typeof(WebActivity));
                i.PutExtra("url", "https://wol.jw.org/es/wol/d/r4/lp-s/202015162");
                this.StartActivity(i);
            }

            if (e.Position == 6)
            {
                Intent i = new Intent(this, typeof(WebActivity));
                i.PutExtra("url", "https://wol.jw.org/es/wol/d/r4/lp-s/202014401");
                this.StartActivity(i);
            }

            if (e.Position == 7)
            {
                Intent i = new Intent(this, typeof(WebActivity));
                i.PutExtra("url", "https://wol.jw.org/es/wol/d/r4/lp-s/202014081");
                this.StartActivity(i);
            }

            if (e.Position == 8)
            {
                Intent i = new Intent(this, typeof(WebActivity));
                i.PutExtra("url", "https://wol.jw.org/es/wol/d/r4/lp-s/202015044");
                this.StartActivity(i);
            }

            if (e.Position == 9)
            {
                Intent i = new Intent(this, typeof(WebActivity));
                i.PutExtra("url", "https://wol.jw.org/es/wol/d/r4/lp-s/202014284");
                this.StartActivity(i);
            }

            if (e.Position == 10)
            {
                Intent i = new Intent(this, typeof(WebActivity));
                i.PutExtra("url", "https://wol.jw.org/es/wol/d/r4/lp-s/201991250");
                this.StartActivity(i);
            }

           
        }
    }
}