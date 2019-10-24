using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ListExercise.Core;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Lists
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    class second_activity : ListActivity
    {
        List<Car> _items;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            var QueryString = "https://metaweather.com/api/location/search/?query=london";
            var data = DataService.GetDataFromService(QueryString);

            _items = new List<Car>()
            {
                new Car(){Manufacturer = "Tesla", Model = "roadster", Year = "2017", KW ="10 Kw"},
                new Car(){Manufacturer = "Tesla", Model = "X", Year = "2015", KW ="11 Kw"},
                new Car(){Manufacturer = "Tesla", Model = "Y", Year = "2019", KW ="13 Kw"},
                new Car(){Manufacturer = "Tesla", Model = "3", Year = "2013", KW ="9 Kw"},
                new Car(){Manufacturer = "Subaru", Model = "onliemilia", Year = "2002", KW ="7 Kw"},
                new Car(){Manufacturer = "Mustang", Model = "Ford", Year = "1990", KW ="15 Kw"},
                new Car(){Manufacturer = "Ford", Model = "Musang", Year = "1992", KW ="10 Kw"},
                new Car(){Manufacturer = "Meek", Model = "Wrap", Year = "1993", KW ="6 Kw"},
                new Car(){Manufacturer = "Seep", Model = "Car", Year = "1995", KW ="5 Kw"},
                new Car(){Manufacturer = "Leak", Model = "Boot", Year = "1997", KW ="8 Kw"},
                new Car(){Manufacturer = "Weep", Model = "LandCar", Year = "2000", KW ="7 Kw"},

            };

            ListAdapter = new CarAdapter(this, _items);

            ListView.ItemClick += delegate (object sender, AdapterView.ItemClickEventArgs args)
            {
                var item = _items[args.Position];

                Toast.MakeText(Application, item.Model, ToastLength.Short).Show();
            };
        }

    }
}