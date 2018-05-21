using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

 
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
 
using Android.Support.V4.App;

namespace App2.Fragments
{
    public class DlgSignalStrenthFragment : DialogFragment
    {
        private EditText _txtSignalStrength;

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your fragment here
        }


       public static DlgSignalStrenthFragment CreateInstance()
        {
            DlgSignalStrenthFragment frag = new DlgSignalStrenthFragment();
            return frag;

        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            // Use this to return your custom view for this Fragment
              return inflater.Inflate(Resource.Layout.DlgSignalStrength, container, false);

            
        }

        public override void OnViewCreated(View view, Bundle savedInstanceState)
        {
            base.OnViewCreated(view, savedInstanceState);

            _txtSignalStrength = view.FindViewById<EditText>(Resource.Id.txtSignalStrength);

            var btnOK =   view.FindViewById<Button>(Resource.Id.btnOK);
            btnOK.Click += BtnOK_Click;

            var btnCancel = view.FindViewById<Button>(Resource.Id.btnCancel);
            btnCancel.Click += BtnCancel_Click;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Dismiss();
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            int tempSignalStrength;
            int.TryParse(_txtSignalStrength.Text, out tempSignalStrength);

            ((IOnSignalStrengthDialogFinish)Activity).OnSignalStrengthDialogFinish(tempSignalStrength);

            this.Dismiss();

        }
    }
}