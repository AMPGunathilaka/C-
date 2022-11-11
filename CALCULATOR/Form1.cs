using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CALCULATOR
{
   

    public partial class Form1 : Form
    {
        string operation = "";
        double result_value = 0;
        bool is_operation_perform = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void btn_click(object sender, EventArgs e)
        {
            if (tb_results.Text == "0" || is_operation_perform)
            {
                tb_results.Clear();
            }

            Button btn = (Button)sender;
            tb_results.Text = tb_results.Text + btn.Text;
            is_operation_perform = false;
        }

        private void operationn_performed(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            operation = btn.Text;
            result_value = double.Parse(tb_results.Text);

            lb_results.Text = result_value + operation;
            is_operation_perform = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            tb_results.Text = "0";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            tb_results.Text = "0";
            lb_results.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+" :
                    
                    tb_results.Text = (result_value + double.Parse(tb_results.Text)).ToString();
                    break;

                case "-":

                    tb_results.Text = (result_value - double.Parse(tb_results.Text)).ToString();
                    break;

                case "*":
                    tb_results.Text = (result_value * double.Parse(tb_results.Text)).ToString();
                    break;

                case "/":
                    tb_results.Text = (result_value / double.Parse(tb_results.Text)).ToString();
                    break;


            }
            
        }
    }
}
