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
    public partial class Food : UserControl
    {
        public Food()
        {
            InitializeComponent();
        }
        private void guna2Panel1_Click(object sender, EventArgs e)
        {
            if (guna2GradientButton1.Visible == false)
            {
                guna2GradientButton1.Visible = true;
                guna2Panel1.BorderThickness = 5;
            }
            else
            {
                guna2GradientButton1.Visible = false;
                guna2Panel1.BorderThickness = 0;
            }
        }
        private void AppToMenu()
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            guna2Panel1_Click(sender, e);
        }

        private void guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {
            guna2Panel1_Click(sender, e);
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            guna2Panel1_Click(sender, e);
        }
    }
}
