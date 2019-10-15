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

namespace List_Exercise
{
    [Activity(Label = "Second_Activity")]
    public class Second_Activity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Second_Layout);

            var listView1 = FindViewById<ListView>(Resource.Id.listView1);

            var _items = new List<WeatherInfo>()
            {
                new WeatherInfo(){Name="Weekday:", Temperature="Temperature:", WindSpeed="Windspeed:"},
                new WeatherInfo(){Name = "Esmaspäev", Temperature = "12C", WindSpeed = "4m/s"},
                new WeatherInfo(){Name = "Teisipäev", Temperature = "9C", WindSpeed = "5m/s"},
                new WeatherInfo(){Name = "Kolmapäev", Temperature = "6C", WindSpeed = "3m/s"},
                new WeatherInfo(){Name = "Neljapäev", Temperature = "8C", WindSpeed = "2m/s"},
                new WeatherInfo(){Name = "Reede", Temperature = "11C", WindSpeed = "3m/s"},
                new WeatherInfo(){Name = "Laupäev", Temperature = "10C", WindSpeed = "5m/s"},
                new WeatherInfo(){Name = "Pühapäev", Temperature = "7C", WindSpeed = "7m/s"},

            };

            listView1.Adapter = new BasicAdapter(this, _items);

        }
    }
}