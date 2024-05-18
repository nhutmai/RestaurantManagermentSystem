using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManagermentSystem
{
    public partial class FHome : Form
    {
        public FHome()
        {
            InitializeComponent();
        }

        private void FHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc là muốn thoát không?", "Quản lý nhà hàng", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FHome_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            string text = InputDiscount.Text;
            Total.Text = "112312332232";
            Subtotal.Text = text;
            Discount.Text = text;
        }

        private void BSave_Click(object sender, EventArgs e)
        {
            Total.Text="111";
        }
    }
}
