using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AlcAgeLab
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        public void Btn_Clicked (object sender, System.EventArgs e)
        {
            DateTime date = Inp_date.Date;
            DateTime now = DateTime.Now;
            TimeSpan age = now - date;
            string days = age.ToString("dddd");
            int difference = Int32.Parse(days);
            int years = difference / 365;
            Lbl_age.Text = $"Age: {years}";
            if(years < 21)
            {
                int diff = 21 - years;
                Lbl_status.Text = $"You have {diff} years until you are 21";
            } else
            {
                Lbl_status.Text = $"You're legal";
            }
            
        }
    }
}
