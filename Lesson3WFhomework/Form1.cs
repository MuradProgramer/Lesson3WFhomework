using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson3WFhomework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtb_priceGS.Text = null;
            rb_price.Enabled = false;
            rb_quantity.Enabled = false;
            rb_price.Checked = false;
            rb_quantity.Checked = false;
            txtb_hotdogcount.Enabled = false;
            txtb_hambCount.Enabled = false;
            txtb_pttCount.Enabled = false;
            txtb_colaCount.Enabled = false;
            txtb_priceG.Enabled = false;
            txtb_quantity.Enabled = false;
            txtb_quantity.Text = null;
            cmbb_gasoline.Text = null;
            lbl_pay1.Text = "0,00";
            ckb_cocacola.Checked = false;
            ckb_hamburger.Checked = false;
            ckb_hotdog.Checked = false;
            ckb_potFree.Checked = false;
            txtb_colaCount.Text = null;
            txtb_hambCount.Text = null;
            txtb_hotdogcount.Text = null;
            txtb_pttCount.Text = null;
            lbl_pay2.Text = "0,00";
            lbl_pay3.Text = "0,00";
        }

        #region GasStation

        private void cmbb_gasoline_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> petrols = new List<string>() { "AI-76", "AI-95", "AI-98", "Dizel" };
            rb_price.Enabled = true;
            rb_quantity.Enabled = true;
            switch (cmbb_gasoline.Text)
            {
                case "AI-76":
                    txtb_priceGS.Text = "6,4";
                    break;
                case "AI-95":
                    txtb_priceGS.Text = "2,1";
                    break;
                case "AI-98":
                    txtb_priceGS.Text = "2,7";
                    break;
                case "Dizel":
                    txtb_priceGS.Text = "5,0";
                    break;
            }
        }

        private void rb_quantity_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_quantity.Checked)
            {
                txtb_priceG.Enabled = false;
                txtb_priceG.Text = null;
                txtb_quantity.Enabled = true;
            }
        }

        private void rb_price_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_price.Checked)
            {
                txtb_priceG.Enabled = true;
                txtb_quantity.Enabled = false;
                txtb_quantity.Text = null;
            }
        }

        private void txtb_quantity_TextChanged(object sender, EventArgs e)
        {
            double number;
            bool success = double.TryParse(txtb_quantity.Text, out number);
            if (txtb_quantity.Text == null || !success || number < 0)
                return;
            lbl_pay1.Text = (number * double.Parse(txtb_priceGS.Text)).ToString();
        }

        private void txtb_priceG_TextChanged(object sender, EventArgs e)
        {
            double number;
            bool success = double.TryParse(txtb_priceG.Text, out number);
            if (txtb_priceG.Text == null || !success || number < 0)
                return;
            int count = (int)(number / double.Parse(txtb_priceGS.Text));
            lbl_pay1.Text = (count * double.Parse(txtb_priceGS.Text)).ToString();
        }
        #endregion

        #region MiniCafe

        private void ckb_hotdog_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is CheckBox ckb)
            {
                switch (ckb.Text)
                {
                    case "Hot-Dog":
                        txtb_hotdogcount.Enabled = ckb.Checked;
                        break;
                    case "Hamburger":
                        txtb_hambCount.Enabled = ckb.Checked;
                        break;
                    case "Potatoe Free":
                        txtb_pttCount.Enabled = ckb.Checked;
                        break;
                    case "Coca-Cola":
                        txtb_colaCount.Enabled = ckb.Checked;
                        break;
                }
            }  
        }

        private void txtb_hotdogcount_TextChanged(object sender, EventArgs e)
        {
            lbl_pay2.Text = "0,00";
            int count1;
            bool success = int.TryParse(txtb_hotdogcount.Text, out count1);
            if (txtb_hotdogcount.Text != null && success && txtb_hotdogcount.Enabled == true
                && count1 >= 0)
                lbl_pay2.Text = (double.Parse(lbl_pay2.Text) + count1 * 4.00).ToString();


            int count2;
            success = int.TryParse(txtb_hambCount.Text, out count2);
            if (txtb_hambCount.Text != null && success && txtb_hambCount.Enabled == true
                && count2 >= 0)
                lbl_pay2.Text = (double.Parse(lbl_pay2.Text) + count2 * 5.40).ToString();

            int count3;
            success = int.TryParse(txtb_pttCount.Text, out count3);
            if (txtb_pttCount.Text != null && success && txtb_pttCount.Enabled == true
                && count3 >= 0)
                lbl_pay2.Text = (double.Parse(lbl_pay2.Text) + count3 * 7.20).ToString();

            int count4;
            success = int.TryParse(txtb_colaCount.Text, out count4);
            if (txtb_colaCount.Text != null && success && txtb_colaCount.Enabled == true
                && count4 >= 0)
                lbl_pay2.Text = (double.Parse(lbl_pay2.Text) + count4 * 4.40).ToString();
        }

        private void btn_calculate_Click(object sender, EventArgs e)
        {
            lbl_pay3.Text = (double.Parse(lbl_pay1.Text) + double.Parse(lbl_pay2.Text)).ToString();
        }

        private void btn_pay_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank You!", "Caption");
            Form1_Load(sender, e);
        }

        #endregion
    }
}
