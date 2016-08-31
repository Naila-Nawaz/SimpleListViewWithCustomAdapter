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

namespace SimpleListView
{
    public class ListAdapter : BaseAdapter<Student>
    {
        readonly Activity context;
        readonly List<Student> students;
        public ListAdapter(Activity context, List<Student> students)
        {
            this.context = context;
            this.students = students;
        }

        public override Student this[int position]
        {
            get { return students[position]; }
        }

        public override int Count
        {
            get { return students.Count; }
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            Student std = students[position];
            View view = convertView;
            if (view == null) // no view to re-use, create new
            {
                view = context.LayoutInflater.Inflate(Resource.Layout.listItem, null);
            }
            view.FindViewById<TextView>(Resource.Id.Text1).Text = std.name;
            view.FindViewById<TextView>(Resource.Id.Text2).Text = std.cgpa;

            return view;
        }
    }
}