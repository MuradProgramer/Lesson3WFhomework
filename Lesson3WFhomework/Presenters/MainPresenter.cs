using Lesson3WFhomework.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson3WFhomework.Presenters
{
    public class MainPresenter
    {
        private readonly IMainView mainView;

        public MainPresenter(IMainView view)
        {
            mainView = view;

            mainView.FormLoadEventHandler += Form1_Load;

            // Gasoline Station
            mainView.CmbGasolineSelectedIndexChangedEventHandler += cmbb_gasoline_SelectedIndexChanged;
            mainView.RbPriceCheckedChangedEventHandler += rb_price_CheckedChanged;
            mainView.RbQuantityCheckedChangedEventHandler += rb_quantity_CheckedChanged;
            mainView.TxtbQuantityTextChangedEventHandler += txtb_quantity_TextChanged;
            mainView.TxtbPriceTextChangedEventHandler += txtb_priceG_TextChanged;

            // Mini-Cafe
            mainView.CkbCheckedChangedEventHandler += ckb_hotdog_CheckedChanged;
            mainView.TxtbCountTextChangedEventHandler += txtb_hotdogcount_TextChanged;
            mainView.BtnCalculateClickEventHandler += btn_calculate_Click;
            mainView.BtnPayClickEventHandler += btn_pay_Click;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mainView.GasolinePriceText = null;
            mainView.RbPriceChecked = false;
            mainView.RbQuantityChecked = false;

            mainView.HotDogCountEnabled = false;
            mainView.HambCountEnabled = false;
            mainView.PttCountEnabled = false;
            mainView.ColaCountEnabled = false;

            mainView.CkbColChecked = false;
            mainView.CkbHambChecked = false;
            mainView.CkbPttChecked = false;
            mainView.CkbHotDogChecked = false;


            mainView.ManatText = null;
            mainView.LitrText = null;
            mainView.CmbbGasolineText = null;

            mainView.Pay1Text = "0,00";

            mainView.CountColaText = null;
            mainView.CountHamburgerText = null;
            mainView.CountHotDogText = null;
            mainView.CountPropertyText = null;

            mainView.Pay2Text = "0,00";
            mainView.PayFinalText = "0,00";
        }

        #region GasStation

        private void cmbb_gasoline_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> petrols = new List<string>() { "AI-76", "AI-95", "AI-98", "Dizel" };
            switch (mainView.CmbbGasolineText)
            {
                case "AI-76":
                    mainView.GasolinePriceText = "6,4";
                    break;
                case "AI-95":
                    mainView.GasolinePriceText = "2,1";
                    break;
                case "AI-98":
                    mainView.GasolinePriceText = "2,7";
                    break;
                case "Dizel":
                    mainView.GasolinePriceText = "5,0";
                    break;
            }
        }

        private void rb_quantity_CheckedChanged(object sender, EventArgs e)
        {
            if (mainView.RbQuantityChecked)
                mainView.ManatText = null;
        }

        private void rb_price_CheckedChanged(object sender, EventArgs e)
        {
            if (mainView.RbPriceChecked)
                mainView.LitrText = null;
        }

        private void txtb_quantity_TextChanged(object sender, EventArgs e)
        {
            double number;
            bool success = double.TryParse(mainView.LitrText, out number);
            if (mainView.LitrText == null || !success || number < 0)
                return;
            mainView.Pay1Text = (number * double.Parse(mainView.GasolinePriceText)).ToString();
        }

        private void txtb_priceG_TextChanged(object sender, EventArgs e)
        {
            double number;
            bool success = double.TryParse(mainView.ManatText, out number);
            if (mainView.ManatText == null || !success || number < 0)
                return;
            int count = (int)(number / double.Parse(mainView.GasolinePriceText));
            mainView.Pay1Text = (count * double.Parse(mainView.GasolinePriceText)).ToString();
        }
        #endregion

        #region MiniCafe
        private void ckb_hotdog_CheckedChanged(object sender, EventArgs e)
        {
            mainView.ColaCountEnabled = mainView.CkbColChecked;
            if (!mainView.ColaCountEnabled) mainView.CountColaText = null;

            mainView.HambCountEnabled = mainView.CkbHambChecked;
            if (!mainView.HambCountEnabled) mainView.CountHamburgerText = null;

            mainView.PttCountEnabled = mainView.CkbPttChecked;
            if (!mainView.PttCountEnabled) mainView.CountPropertyText = null;

            mainView.HotDogCountEnabled = mainView.CkbHotDogChecked;
            if (!mainView.HotDogCountEnabled) mainView.CountHotDogText = null;
        }

        private void txtb_hotdogcount_TextChanged(object sender, EventArgs e)
        {
            mainView.Pay2Text = "0,00";
            int count1;
            bool success = int.TryParse(mainView.CountHotDogText, out count1);
            if (mainView.CountHotDogText != null && success && mainView.HotDogCountEnabled == true
                && count1 >= 0)
                mainView.Pay2Text = (double.Parse(mainView.Pay2Text) + count1 * 4.00).ToString();


            int count2;
            success = int.TryParse(mainView.CountHamburgerText, out count2);
            if (mainView.CountHamburgerText != null && success && mainView.HambCountEnabled == true
                && count2 >= 0)
                mainView.Pay2Text = (double.Parse(mainView.Pay2Text) + count2 * 5.40).ToString();

            int count3;
            success = int.TryParse(mainView.CountPropertyText, out count3);
            if (mainView.CountPropertyText != null && success && mainView.PttCountEnabled == true
                && count3 >= 0)
                mainView.Pay2Text = (double.Parse(mainView.Pay2Text) + count3 * 7.20).ToString();

            int count4;
            success = int.TryParse(mainView.CountColaText, out count4);
            if (mainView.CountColaText != null && success && mainView.ColaCountEnabled == true
                && count4 >= 0)
                mainView.Pay2Text = (double.Parse(mainView.Pay2Text) + count4 * 4.40).ToString();
        }

        private void btn_calculate_Click(object sender, EventArgs e)
        {
            mainView.PayFinalText = (double.Parse(mainView.Pay1Text) + double.Parse(mainView.Pay2Text)).ToString();
        }

        private void btn_pay_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank You!", "Caption");
            Form1_Load(sender, e);
        }

        #endregion
    }
}
