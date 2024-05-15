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

        private void Food_Click(object sender, EventArgs e)
        {
            guna2GradientButton1.Visible = false;
        }
    }
}
