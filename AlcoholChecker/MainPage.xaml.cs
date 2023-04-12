using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AlcoholChecker
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        void Handle_Clicked(object sender, System.EventArgs e)
        {
            // int age = Int32.Parse(Age.Text);
            var birthday = Birthday.Date;
            //DateTime currentDateTime = DateTime.Today.ToLocalTime();
            //DateTime zeroTime = new DateTime(1, 1, 1);
            int age = (int)((DateTime.Now - birthday).TotalDays / 365.242199);
            //TimeSpan timeSpan = currentDateTime - Birthday.Date;
            //int years = (zeroTime + timeSpan).Year - 1;
            int result = 21 - age;
            int years = 18 - age;
            if (age < 18)
                alabel.Text = $"You're {age} years old, {result} more years to reach the legal age in US, {years} more years to reach the legal age in England/China/Australia.";
            else if (age >= 18 && age < 21)
                alabel.Text = $"You're {age} years old. You're qualified to purchase alcohol in England/China/Australia. {result} more years to reach the legal age in US.";
            else
                alabel.Text = $"You are {age} and qualified to purchase alcohol in England/China/Australia/US.";
            //if (result > 0)
            //    alabel.Text = $"You're {age} years old, there are {result} years until you are 21.";
            //else
            //    alabel.Text = $"You are {age} and qualified to purchase alcohol!";
        }
    }
}
