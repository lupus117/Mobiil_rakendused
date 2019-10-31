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
    class StarAdapter : BaseAdapter<PeopleDetails>
    {
        List<PeopleDetails> _items;
        Activity _context;


        public StarAdapter(Activity context, List<PeopleDetails> items) : base()
        {
            this._context = context;
            this._items = items;
        }

        public override PeopleDetails this[int position]
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
                view = _context.LayoutInflater.Inflate(Resource.Layout.people_row_layout, null);
            }
            
            view.FindViewById<TextView>(Resource.Id.textView_Name).Text = "Name: " + item.name;
            view.FindViewById<TextView>(Resource.Id.textView_Height).Text = "Height: " + item.height;
            view.FindViewById<TextView>(Resource.Id.textView_Mass).Text = "Mass: " + item.mass;
            view.FindViewById<TextView>(Resource.Id.textView_Gender).Text = "Gender: " + item.gender;
            view.FindViewById<TextView>(Resource.Id.textView_Homeworld).Text = "Homeworld: " + item.homeworld;
            view.FindViewById<TextView>(Resource.Id.textView_Hair).Text = "Hair: " + item.hair_color;
            view.FindViewById<TextView>(Resource.Id.textView_Skin).Text = "Skin: " + item.skin_color;
            view.FindViewById<TextView>(Resource.Id.textView_Eye).Text = "Eyes: " + item.eye_color;
            view.FindViewById<TextView>(Resource.Id.textView_Birth).Text = "Born: " + item.birth_year;
            
            return view;
        }
    }
}