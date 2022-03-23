using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson3WFhomework.Views
{
    public partial class MainView : Form, IMainView
    {
        public MainView()
        {
            InitializeComponent();
        }

        public EventHandler<EventArgs> FormLoadEventHandler { get; set; }

        // Gasoline Stor
        public EventHandler<EventArgs> CmbGasolineSelectedIndexChangedEventHandler { get; set; }

        public EventHandler<EventArgs> RbQuantityCheckedChangedEventHandler { get; set; }

        public EventHandler<EventArgs> RbPriceCheckedChangedEventHandler { get; set; }

        public EventHandler<EventArgs> TxtbQuantityTextChangedEventHandler { get; set; }

        public EventHandler<EventArgs> TxtbPriceTextChangedEventHandler { get; set; }

        // Mini-Cafe
        public EventHandler<EventArgs> CkbCheckedChangedEventHandler { get; set; }

        public EventHandler<EventArgs> TxtbCountTextChangedEventHandler { get; set; }

        public EventHandler<EventArgs> BtnCalculateClickEventHandler { get; set; }

        public EventHandler<EventArgs> BtnPayClickEventHandler { get; set; }


        public string LitrText 
        { 
            get => txtb_quantity.Text; 
            set => txtb_quantity.Text = value; 
        }

        public string ManatText
        {
            get => txtb_priceG.Text;
            set => txtb_priceG.Text = value;
        }

        public string CountHotDogText
        {
            get => txtb_hotdogcount.Text;
            set => txtb_hotdogcount.Text = value;
        }

        public string CountHamburgerText
        {
            get => txtb_hambCount.Text;
            set => txtb_hambCount.Text = value;
        }

        public string CountColaText
        {
            get => txtb_colaCount.Text;
            set => txtb_colaCount.Text = value;
        }

        public string CountPropertyText
        {
            get => txtb_pttCount.Text;
            set => txtb_pttCount.Text = value;
        }

        public string Pay1Text
        {
            get => lbl_pay1.Text;
            set => lbl_pay1.Text = value;
        }

        public string Pay2Text
        {
            get => lbl_pay2.Text;
            set => lbl_pay2.Text = value;
        }

        public string PayFinalText
        {
            get => lbl_pay3.Text;
            set => lbl_pay3.Text = value;
        }

        public string GasolinePriceText
        {
            get => txtb_priceGS.Text;
            set => txtb_priceGS.Text = value;
        }

        public string CmbbGasolineText
        {
            get => cmbb_gasoline.Text;
            set => cmbb_gasoline.Text = value;
        }

        public bool RbQuantityChecked
        {
            get => rb_quantity.Checked;
            set => rb_quantity.Checked = value;
        }

        public bool RbPriceChecked
        {
            get => rb_price.Checked;
            set => rb_price.Checked = value;
        }

        public bool HotDogCountEnabled
        {
            get => txtb_hotdogcount.Enabled;
            set => txtb_hotdogcount.Enabled = value;
        }

        public bool HambCountEnabled
        {
            get => txtb_hambCount.Enabled;
            set => txtb_hambCount.Enabled = value;
        }

        public bool PttCountEnabled
        {
            get => txtb_pttCount.Enabled;
            set => txtb_pttCount.Enabled = value;
        }

        public bool ColaCountEnabled
        {
            get => txtb_colaCount.Enabled;
            set => txtb_colaCount.Enabled = value;
        }

        public bool CkbHotDogChecked
        {
            get => ckb_hotdog.Checked;
            set => ckb_hotdog.Checked = value;
        }

        public bool CkbHambChecked
        {
            get => ckb_hamburger.Checked;
            set => ckb_hamburger.Checked = value;
        }

        public bool CkbPttChecked
        {
            get => ckb_potFree.Checked;
            set => ckb_potFree.Checked = value;
        }

        public bool CkbColChecked
        {
            get => ckb_cocacola.Checked;
            set => ckb_cocacola.Checked = value;
        }


        // Events
        private void MainView_Load(object sender, EventArgs e)
        {
            FormLoadEventHandler.Invoke(sender, e);
        }

        #region GasStation

        private void cmbb_gasoline_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbGasolineSelectedIndexChangedEventHandler.Invoke(sender, e);
        }

        private void rb_quantity_CheckedChanged(object sender, EventArgs e)
        {
            RbQuantityCheckedChangedEventHandler.Invoke(sender, e);
        }

        private void rb_price_CheckedChanged(object sender, EventArgs e)
        {
            RbPriceCheckedChangedEventHandler.Invoke (sender, e);
        }

        private void txtb_quantity_TextChanged(object sender, EventArgs e)
        {
            TxtbQuantityTextChangedEventHandler.Invoke(sender, e);
        }

        private void txtb_priceG_TextChanged(object sender, EventArgs e)
        {
            TxtbPriceTextChangedEventHandler.Invoke(sender, e);
        }
        #endregion

        #region MiniCafe

        private void txtb_hotdogcount_TextChanged(object sender, EventArgs e)
        {
            TxtbCountTextChangedEventHandler.Invoke(sender, e);
        }

        private void btn_calculate_Click(object sender, EventArgs e)
        {
            BtnCalculateClickEventHandler.Invoke(sender, e);
        }

        private void btn_pay_Click(object sender, EventArgs e)
        {
            BtnPayClickEventHandler.Invoke(sender, e);
        }

        private void ckb_hotdog_CheckedChanged(object sender, EventArgs e)
        {
            CkbCheckedChangedEventHandler.Invoke(sender, e);
        }

        #endregion
    }
}
