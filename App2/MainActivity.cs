using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;
using App2.Fragments;

namespace App2
{
    [Activity(Label = "App2", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : AppCompatActivity, IOnSignalStrengthDialogFinish
    {
        int count = 1;

        public void OnSignalStrengthDialogFinish(int signalStrength)
        {
           
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button>(Resource.Id.myButton);

            button.Click += delegate
            {


                ShowDialog();


            };
        }

        private void ShowDialog()
        {
          
            DlgSignalStrenthFragment dlgSignalStrenthFragment = DlgSignalStrenthFragment.CreateInstance();
            dlgSignalStrenthFragment.Show(SupportFragmentManager, "dlgSignalStrenthFragment");
        }

    }
}

