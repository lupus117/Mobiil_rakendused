    using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using StarWarsApp.Core;

namespace StarWarsRakendis
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            var searchBar = FindViewById<EditText>(Resource.Id.searchEditText);
            var searchButtonPeople = FindViewById<Button>(Resource.Id.searchButtonPeople);
            var searchButtonMovies = FindViewById<Button>(Resource.Id.searchButtonMovies);
            var peopleListView = FindViewById<ListView>(Resource.Id.peopleListView);
          
            searchButtonMovies.Click += async delegate
            {
                string searchWord = searchBar.Text;
                string queryString = "https://swapi.co/api/films/?search=" + searchWord;
                var data = await MovieDataService.GetDataFromService(queryString);
                peopleListView.Adapter = new MovieAdapter(this, data.results);

            };

            searchButtonPeople.Click += async delegate
            {
                string searchWord = searchBar.Text;
                string queryString = "https://swapi.co/api/people/?search=" + searchWord;
                var data = await DataService.GetDataFromService(queryString);
                peopleListView.Adapter = new StarAdapter(this, data.results);
               
            };
        }
    }
}