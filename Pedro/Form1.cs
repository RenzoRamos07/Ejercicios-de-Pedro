using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pedro
{
    public partial class Form1 : Form
    {
        int cantidad1, cantidad2, cantidad3;
        int precio1, precio2, precio3;
        public Form1()
        {
            InitializeComponent();
            panel1.Visible =false;
            
        }


        private void btnTotal_Click(object sender, EventArgs e)
        {
            try
            {
                if (cb_producto1.Checked == true && txtProducto1.Text != "")
                {
                    cantidad1 = Convert.ToInt32(txtProducto1.Text);
                    precio1 = cantidad1 * 1200;

                }
                else precio1 = 0;
                if (cb_producto2.Checked == true && txtProducto2.Text != "")
                {
                    cantidad2 = Convert.ToInt32(txtProducto2.Text);
                    precio2 = cantidad2 * 1500;

                }
                else precio2 = 0;
                if (cb_producto3.Checked == true && txtProducto3.Text != "")
                {
                    cantidad3 = Convert.ToInt32(txtProducto3.Text);
                    precio3 = cantidad3 * 2500;

                }
                else precio3 = 0;

                int total = precio1 + precio2 + precio3;

                panel1.Visible = true;

                WASA.Text = Convert.ToString(total);
            }
            catch (Exception)
            {

                MessageBox.Show("No hagas eso papu");
            }
           

        }
    }
}
