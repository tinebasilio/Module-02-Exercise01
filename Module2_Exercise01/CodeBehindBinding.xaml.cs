using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Module2_Exercise01
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CodeBehindBinding : ContentPage
    {
        public CodeBehindBinding()
        {
            InitializeComponent();
            BindingContext = this;
        }

        void OnStepperValueChanged(object sender, ValueChangedEventArgs args)
        {
            myLabel.Rotation = args.NewValue;
        }
        void OnResetLabelClicked(object sender, EventArgs e)
        {
            myLabel.Text = "";
        }
    }
}