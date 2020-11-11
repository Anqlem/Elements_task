using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;



namespace Elements_task
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class horoskoop : ContentPage
    {
        public horoskoop()
        {
            InitializeComponent();
        }

        private void changehoros(object sender, DateChangedEventArgs e)
        {
            change.Text = e.NewDate.ToLongDateString();
            if (change.Text == "Friday, November 13, 2020")
            {
                horos.Source = "Aries.png";
            }
            else if(change.Text== "Friday, November 12, 2020")
            {
                horos.Source = "Cancer.png";
            }
        }

    }
}