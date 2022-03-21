using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Praktikum_Week_5
{
    public partial class formWeek5 : Form
    {
        public formWeek5()
        {
            InitializeComponent();
        }

        private void formWeek5_Load(object sender, EventArgs e)
        {
            lblCetak.Text = "";
            rButtonMerah.Checked = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (lboxKoleksi.Items.Contains(tboxInput.Text))
            {
                MessageBox.Show("Input Kembar");
            }
            else
            {
                lboxKoleksi.Items.Add(tboxInput.Text);
                tboxInput.Text = "";
            }
        }

        private void lboxKoleksi_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblCetak.Text = lboxKoleksi.SelectedItem.ToString();
        }

        private void cBoxAktif_CheckedChanged(object sender, EventArgs e)
        {
            if (cBoxAktif.Checked == true)
            {
                if (rButtonMerah.Checked == true)
                {
                    lblCetak.ForeColor = Color.Red;
                }
                else if (rButtonBiru.Checked == true)
                {
                    lblCetak.ForeColor = Color.Blue;
                }
            }
            else
            {
                lblCetak.ForeColor = Color.Black;
            }
        }

        private void rButtonMerah_CheckedChanged(object sender, EventArgs e)
        {
            if (cBoxAktif.Checked == true)
            {
                if (rButtonMerah.Checked == true)
                {
                    lblCetak.ForeColor = Color.Red;
                }
                else if (rButtonBiru.Checked == true)
                {
                    lblCetak.ForeColor = Color.Blue;
                }
            }
            else
            {
                lblCetak.ForeColor = Color.Black;
            }

        }

        private void rButtonBiru_CheckedChanged(object sender, EventArgs e)
        {
            if (cBoxAktif.Checked == true)
            {
                if (rButtonMerah.Checked == true)
                {
                    lblCetak.ForeColor = Color.Red;
                }
                else if (rButtonBiru.Checked == true)
                {
                    lblCetak.ForeColor = Color.Blue;
                }
            }
            else
            {
                lblCetak.ForeColor = Color.Black;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblCetak.Text = "";
            lboxKoleksi.Items.Clear();
            cBoxAktif.Checked = false;
            rButtonMerah.Checked = true;

        }
    }
}
