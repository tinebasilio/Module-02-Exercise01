﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Module2_Exercise01
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private async void OnViewDataBinding(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ViewDataBinding());
        }

        private async void OnCodeBehindDataBinding(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CodeBehindBinding());
        }

        private async void OnNoBindingContext(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NoBindingContext());
        }

    }
}
