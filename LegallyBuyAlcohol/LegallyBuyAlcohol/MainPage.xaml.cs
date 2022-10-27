using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using static System.Windows.Forms;

namespace LegallyBuyAlcohol
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void DatePicker_DateSelected(object sender, DateChangedEventArgs e)
        {
            //MainLabel.Text = e.NewDate.ToString("MMMM dd, yyyy");
        }

        void Btn_Clicked(object sender, System.EventArgs e) 
        {
            DateTime ageTwentyOne = birthDay.Date.AddYears(21);
            TimeSpan timeSpan = ageTwentyOne.Date - DateTime.Today.Date;

            Lbl_Drink.Text = String.Format("You'll be of drinking age in {0} years!\n\nYour 21st birthday is on {1:MMMM dd, yyyy}",
                                                timeSpan.Days / 365, ageTwentyOne.Date);
        }

    }
}

