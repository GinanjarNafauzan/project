using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorWindowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int Penambahan(int a, int b)
        {
            return a + b;
        }
        private int Pengurangan(int a, int b)
        {
            return a - b;
        }
        private int Perkalian(int a, int b)
        {
            return a * b;
        }
        private int Pembagian(int a, int b)
        {
            return a / b;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var a = int.Parse(txtNilaiA.Text);
            var b = Convert.ToInt32(txtNilaiB.Text);

            lstHasil.Items.Clear();

            if(cmbHasil.SelectedIndex == -1)
            {
                MessageBox.Show("Operator nilai belum terpilih");
            }
            else if(cmbHasil.SelectedIndex == 0)
            {
                lstHasil.Items.Add(string.Format("Hasil Penambahan\t: {0} + {1} = {2}", a, b, Penambahan(a, b)));
            }
            else if(cmbHasil.SelectedIndex == 1)
            {
                lstHasil.Items.Add(string.Format("Hasil Pengurangan\t: {0} - {1} = {2}", a, b, Pengurangan(a, b)));
            }
            else if(cmbHasil.SelectedIndex == 2)
            {
                lstHasil.Items.Add(string.Format("Hasil Perkalian\t: {0} x {1} = {2}", a, b, Perkalian(a, b)));
            }
            else if (cmbHasil.SelectedIndex == 3)
            {
                lstHasil.Items.Add(string.Format("Hasil Pembagian\t: {0} : {1} = {2}", a, b, Pembagian(a, b)));
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
