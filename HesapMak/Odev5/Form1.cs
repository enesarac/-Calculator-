using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev5
{
    public partial class makine : Form
    {
        public makine()
        {
            InitializeComponent();
        }
        bool optDurum = false;
        double sonuc = 0;
        string opt = "";

        private void RakamOlay(object sender, EventArgs e)
        {
            if (txtSonuc.Text == "0" || optDurum)
                txtSonuc.Clear();

            optDurum = false;
            Button btn = (Button)sender;
            txtSonuc.Text += btn.Text;
        }

        private void optHesap(object sender, EventArgs e)
        {
            optDurum = true;
            Button btn = (Button)sender;
            string yeniOpt = btn.Text;
            lbSonuc.Text = lbSonuc.Text + "" + txtSonuc.Text + "" + yeniOpt;

            switch (opt)
            {
                case "+": txtSonuc.Text = (sonuc + Double.Parse(txtSonuc.Text)).ToString(); break;
                case "-": txtSonuc.Text = (sonuc - Double.Parse(txtSonuc.Text)).ToString(); break;
                case "*": txtSonuc.Text = (sonuc * Double.Parse(txtSonuc.Text)).ToString(); break;
                case "/": txtSonuc.Text = (sonuc / Double.Parse(txtSonuc.Text)).ToString(); break;
            }
            sonuc = double.Parse(txtSonuc.Text);
            txtSonuc.Text = sonuc.ToString();
            opt = yeniOpt;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            txtSonuc.Text = "0";
            lbSonuc.Text = "";
            opt = "";
            optDurum = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (txtSonuc.Text == "0")
            {
                txtSonuc.Text = "0";
            }
            else if (optDurum)
            {
                txtSonuc.Text = "0";
            }
            if (!txtSonuc.Text.Contains(","))
            {
                txtSonuc.Text += ",";
            }
            optDurum = false;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            lbSonuc.Text = "";
            optDurum = true;
            switch (opt)
            {
                case "+": txtSonuc.Text = (sonuc + Double.Parse(txtSonuc.Text)).ToString(); break;
                case "-": txtSonuc.Text = (sonuc - Double.Parse(txtSonuc.Text)).ToString(); break;
                case "*": txtSonuc.Text = (sonuc * Double.Parse(txtSonuc.Text)).ToString(); break;
                case "/": txtSonuc.Text = (sonuc / Double.Parse(txtSonuc.Text)).ToString(); break;
            }
            sonuc = double.Parse(txtSonuc.Text);
            txtSonuc.Text = sonuc.ToString();
            opt = "";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            double sayi = Convert.ToDouble(txtSonuc.Text);
            double sonuc = Math.Cos(sayi);
            txtSonuc.Text = sonuc.ToString();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            double sayi = Convert.ToDouble(txtSonuc.Text);
            double sonuc = Math.Sin(sayi);
            txtSonuc.Text = sonuc.ToString();
        }

        private void hesap_Load(object sender, EventArgs e)
        {

        }
    }
}
