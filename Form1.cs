using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_Bai15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void picTurnOn_Click(object sender, EventArgs e)
        {
            picTurnOn.Visible = false;
            picTurnOff.Visible = true;
            lblHienThi.Text = txtName.Text + " Turn Off the Light ,please!”";
        }

        private void picTurnOff_Click(object sender, EventArgs e)
        {
            picTurnOn.Visible = true;
            picTurnOff.Visible = false;
            lblHienThi.Text = txtName.Text + " Turn On the Light ,please!”";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtName.Text = "";
            lblHienThi.Text = txtName.Text + " ,Turn Off the Light ,please!”";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
            
        }

        private void picTurnOff_MouseHover(object sender, EventArgs e)
        { 
            toolTip1.Show("Click Me to Turn ON the Light!", picTurnOff);
        }

        private void picTurnOn_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Click Me to Turn OFF the Light!", picTurnOn);
        }
    }
}
