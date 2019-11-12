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
using StarWarsApp.Core.Models;

namespace StarWarsRakendis
{
    class MovieAdapter : BaseAdapter<MoviesDetails>
    {
        List<MoviesDetails> _items;
        Activity _context;


        public MovieAdapter(Activity context, List<MoviesDetails> items) : base()
        {
            this._context = context;
            this._items = items;
        }

        public override MoviesDetails this[int position]
        {
            get { return _items[position]; }
        }

        public override int Count
        {
            get { return _items.Count; }
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var item = _items[position];

            View view = convertView;
            if (view == null)
            {
                view = _context.LayoutInflater.Inflate(Resource.Layout.movie_row_layout, null);
            }
            
            view.FindViewById<TextView>(Resource.Id.txt_name).Text = "Name: " + item.title;
            view.FindViewById<TextView>(Resource.Id.txt_year).Text = "Year: " + item.release_date;
            view.FindViewById<TextView>(Resource.Id.txt_desc).Text = "Description: " + item.opening_crawl;
            return view;
        }
    }
}