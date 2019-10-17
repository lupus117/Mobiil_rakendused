﻿using System;
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
    class BasicAdapterCar : BaseAdapter<Car>
    {
        List<Car> _items;
        Activity _context;

        public BasicAdapterCar(Activity context, List<Car> items) : base()
        {
            this._context = context;
            this._items = items;
        }

        public override Car this[int position]
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
                view = _context.LayoutInflater.Inflate(Resource.Layout.Second_Layout, null);

            view.FindViewById<TextView>(Resource.Id.text_view1).Text = "Car Name: " + item.Name;
            view.FindViewById<TextView>(Resource.Id.text_view2).Text = "Manufacturer: " + item.Manufacturer;
            view.FindViewById<TextView>(Resource.Id.text_view3).Text = "Model: " + item.Model;
            view.FindViewById<TextView>(Resource.Id.text_view4).Text = "KW: " + item.KW;
            view.FindViewById<TextView>(Resource.Id.text_view5).Text = "First release: " + item.Year;

            return view;
        }
    }
}