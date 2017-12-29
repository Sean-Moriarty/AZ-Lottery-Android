using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace ArizonaLotteryApp
{
    [Activity(Label = "ArizonaLotteryApp", MainLauncher = true)]
    public class MainActivity : Activity
    {

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            TextView resultText = FindViewById<TextView>(Resource.Id.resultText);
            Button powerButton = FindViewById<Button>(Resource.Id.powerButton);
            Button pickButton = FindViewById<Button>(Resource.Id.pickButton);
            Button megaButton = FindViewById<Button>(Resource.Id.megaButton);

            // generate and display numbers.
            string results = string.Empty;

            powerButton.Click += (object sender, EventArgs e) =>
            {
                resultText.Text = PowerBall.PowerResults();
            };

            pickButton.Click += (object sender, EventArgs e) =>
            {
                resultText.Text = ThePick.PickResults();
            };

            megaButton.Click += (object sender, EventArgs e) =>
            {
                resultText.Text = MegaMillions.MegaResults();
            };
        }
    }
}

