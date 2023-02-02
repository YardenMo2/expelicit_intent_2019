using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidX.AppCompat.App;
using System;

namespace expelicit_intent_2019
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        private Button btndial;
        private Button btnweb;
        private Button btbyoutube;
        private Button btnemail;
        private Button btnsms;
        private Button btnwaze;
        private Button btnwhatsphone;
        private Button btnwhatsnophone;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
                SetContentView(Resource.Layout.activity_main);
            initializeViews();
        }

        private void initializeViews()
        {
            btndial = FindViewById<Button>(Resource.Id.btndial);
            btnweb = FindViewById<Button>(Resource.Id.btnweb);
            btbyoutube = FindViewById<Button>(Resource.Id.btbyoutube);
            btnemail = FindViewById<Button>(Resource.Id.btnemail);
            btnsms = FindViewById<Button>(Resource.Id.btnsms);
            btnwaze = FindViewById<Button>(Resource.Id.btnwaze);
            btnwhatsphone = FindViewById<Button>(Resource.Id.btnwhatsphone);
            btnwhatsnophone = FindViewById<Button>(Resource.Id.btnwhatsnophone);

            btnemail.Click += Btnemail_Click;
        }

        private void Btnemail_Click(object sender, EventArgs e)
        {
            Intent emailintent = new Intent(this, typeof(ActivityEmail));
            StartActivity(emailintent);
        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            this.MenuInflater.Inflate(Resource.Menu.appmenu, menu);
            return base.OnCreateOptionsMenu(menu);
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}