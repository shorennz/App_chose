using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App_chose
{
    public partial class MainPage : ContentPage
    {
        StringBuilder password = new StringBuilder();
        int i = 0;
        public MainPage()
        {
            InitializeComponent();
            Num_1.Clicked += (sender, e) =>
            {
                password.Append("1");
                i++;
                PinAdd();
            };
            Num_2.Clicked += (sender, e) =>
            {
                password.Append("2");
                i++;
                PinAdd();
            };
            Num_3.Clicked += (sender, e) =>
            {
                password.Append("3");
                i++;
                PinAdd();
            };
            Num_4.Clicked += (sender, e) =>
            {
                password.Append("4");
                i++;
                PinAdd();
            };
            Num_5.Clicked += (sender, e) =>
            {
                password.Append("5");
                i++;
                PinAdd();
            };
            Num_6.Clicked += (sender, e) =>
            {
                password.Append("6");
                i++;
                PinAdd();
            };
            Num_7.Clicked += (sender, e) =>
            {
                password.Append("7");
                i++;
                PinAdd();
            };
            Num_8.Clicked += (sender, e) =>
            {
                password.Append("8");
                i++;
                PinAdd();
            };
            Num_9.Clicked += (sender, e) =>
            {
                password.Append("9");
                i++;
                PinAdd();
            };
            Num_0.Clicked += (sender, e) =>
            {
                password.Append("0");
                i++;
                PinAdd();
            };
            Num_del.Clicked += (sender, e) =>
            {
                if (i == 0) { }
                else
                {
                    password.Remove(password.Length - 1, 1);
                    i--;
                    PinDel();
                }
            };
        }
        public void PinAdd()
        {
            if (i == 1) Pin1.Text = password.ToString(0, 1);
            if (i == 2) Pin2.Text = password.ToString(1, 1);
            if (i == 3) Pin3.Text = password.ToString(2, 1);
            if (i == 4) Pin4.Text = password.ToString(3, 1);
            CheckPin();
        }
        public void PinDel()
        {
            if (i < 1) Pin1.Text = "";
            if (i < 2) Pin2.Text = "";
            if (i < 3) Pin3.Text = "";
            if (i < 4) Pin4.Text = "";
        }
        public void CheckPin()
        {
            /* Check Pin here */
            /* if (PIN == 1234) = TRUE */
            if (password.Length == 4)
            {
                if (password.ToString() == "1234")
                {
                    DisplayAlert("CHECKPIN", "TRUE", "OK");
                }
                else /* if (PIN != 1234) = FALSE // clear 4 pin & clear password & clear i */
                {
                    DisplayAlert("CHECKPIN", "FALSE", "OK");
                    Pin1.Text = "";
                    Pin2.Text = "";
                    Pin3.Text = "";
                    Pin4.Text = "";
                    password.Clear();
                    i = 0;
                }
            }
        }
    }
}
