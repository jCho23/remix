using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace remix.Layouts
{
    public partial class Stack : ContentPage
    {
        public Stack()
        {
            InitializeComponent();

            slider.Value = 0.5;
        }

    //    void Handle_ValueChanged(object sender, Xamarin.Forms.ValueChangedEventArgs e)
    //    {
    //        label.Text = String.Format("Value is {0:F2}", e.NewValue);
    //    }
     }
}
