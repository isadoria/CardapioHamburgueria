using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardapioHamburgueria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmbPedido_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void checkBox29_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox30_CheckedChanged(object sender, EventArgs e)
        {

        }
        double total;
        
        private void btnFinal_Click(object sender, EventArgs e)
        {total = 0;
            
            if (cmbPedido.SelectedIndex==0)
            {total = 20.00;}

            else if(cmbPedido.SelectedIndex==1)
            { total = 19.00; }

            else if( cmbPedido.SelectedIndex==2)
            { total = 18.00; }

            else if(cmbPedido.SelectedIndex==3)
                { total = 27.00; }

            else if (cmbPedido.SelectedIndex==4)
            { total = 25.00; }

            else if(cmbPedido.SelectedIndex==5)
            { total = 10.00; }

            

            if (chkRosbife.Checked)
            { total = total+8.00; }

            if (chkBacon.Checked)
            { total = total+3.00; }

            if (chkCheddar.Checked)
            { total = total+2.50; }

            if (chkOvo.Checked)
            { total = total+1.00; }

            if (chkOnion.Checked)
            { total = total+5.50; }

            lblTotal.Text = total.ToString("C");

        }
    }
}
