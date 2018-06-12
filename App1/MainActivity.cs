﻿using System;
using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;

namespace App1
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        Button btnAuth;
        EditText lblUsuario;
        EditText lblContrasenia;
        EditText lblToken;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            btnAuth = FindViewById<Button>(Resource.Id.btnAuth);
            lblUsuario = FindViewById<EditText>(Resource.Id.lblUsuario);
            lblContrasenia = FindViewById<EditText>(Resource.Id.lblConstrasenia);
            lblToken = FindViewById<EditText>(Resource.Id.lblToken);
            btnAuth.Click += DoAuthentication;
           
        }
        private void DoAuthentication(object sender, EventArgs e)
        {
           
            if (lblUsuario.Text.Equals("RDQG") && lblContrasenia.Text.Equals("123456") && lblToken.Text.Equals("13245678"))
            {
                Toast.MakeText(this, "Usuario valido", ToastLength.Short).Show();
            }
            else
            {
                Toast.MakeText(this, "Usuario invalidom este teléfono se destruirá.", ToastLength.Short).Show();
            }
        }
    }
}

