using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace expelicit_intent_2019
{
    [Activity(Label = "ActivityEmail")]
    public class ActivityEmail : Activity
    {
        private EditText etmail;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.activity_email);
            // Create your application here
            initializeViews();

        }

        private void initializeViews()
        {
           
        }
    }
}