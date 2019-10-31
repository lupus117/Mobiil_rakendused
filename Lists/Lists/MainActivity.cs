using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using System.Collections.Generic;
using Android.Content;

namespace Lists
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = false)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(  savedInstanceState);

            SetContentView(Resource.Layout.activity_main);

            var Istbtn = FindViewById<Button>(Resource.Id.btn1);
            var IIstbtn = FindViewById<Button>(Resource.Id.btn2);
            var IIIstbtn = FindViewById<Button>(Resource.Id.btn3);

            Istbtn.Click += Istbtn_Click;
            IIstbtn.Click += IIstbtn_Click;
            IIIstbtn.Click += IIIstbtn_Click;
        }

        private void IIIstbtn_Click(object sender, System.EventArgs e)
        {
            var intent = new Intent(this, typeof(FirstActivity));
            this.StartActivity(intent);
        }

        private void IIstbtn_Click(object sender, System.EventArgs e)
        {
            var intent = new Intent(this, typeof(second_activity));
            this.StartActivity(intent);
        }

        private void Istbtn_Click(object sender, System.EventArgs e)
        {
            var intent = new Intent(this, typeof(Star_activity));
            this.StartActivity(intent);
        }
    }
}