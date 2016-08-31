using Android.App;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;

namespace SimpleListView
{
    [Activity(Label = "ListViewTutorial", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        static readonly int INITIAL_SELECTION = 4;

        readonly List<Student> students = new List<Student>();
        ListView listView;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.ListView);

            populateList();
            InitializeListView();
            listView.SetItemChecked(INITIAL_SELECTION, true);
        }
        void InitializeListView()
        {
            listView = FindViewById<ListView>(Resource.Id.listView);
            listView.Adapter = new ListAdapter(this, students);// setting adapter
            // Important - Set the ChoiceMode
            listView.ChoiceMode = ChoiceMode.Single;
        }

        protected void populateList()
        {
            students.Add(new Student { name = "student1", cgpa = "2.1" });
            students.Add(new Student { name = "student2", cgpa = "2.2" });
            students.Add(new Student { name = "student3", cgpa = "2.3" });
            students.Add(new Student { name = "student4", cgpa = "2.4" });
            students.Add(new Student { name = "student5", cgpa = "2.5" });
            students.Add(new Student { name = "student6", cgpa = "2.6" });
            students.Add(new Student { name = "student7", cgpa = "2.7" });
            students.Add(new Student { name = "student8", cgpa = "2.8" });
            students.Add(new Student { name = "student9", cgpa = "2.9" });
            students.Add(new Student { name = "student10", cgpa = "3.0" });
        }
    }
}

