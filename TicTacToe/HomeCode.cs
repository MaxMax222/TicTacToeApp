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

namespace TicTacToe
{
    [Activity(Label = "Tic Tac Toe", MainLauncher = true)]
    public class HomeCode : Activity
    {
        Button transfer;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.HomePage);
            // Create your application here
            transfer = FindViewById<Button>(Resource.Id.transfer);

            transfer.Click += Transfer_Click;
        }

        private void Transfer_Click(object sender, EventArgs e)
        {
            StartActivity(typeof(MainActivity));
        }
    }
}