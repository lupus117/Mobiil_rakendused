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
    [Activity(Label = "StarWarsLauncher")]
    class Star_activity : ListActivity
    {
        List<Car> _items;
        protected async override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            var QueryString = "https://swapi.co/api/people/?search=darth";
            var data = await DataService.GetDataFromService(QueryString);
            var People = data as People;
            ListAdapter = new StarAdapter(this, People.results);
        }

    }
}