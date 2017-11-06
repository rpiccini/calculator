using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPNCalculator
{
    public partial class RPNCalculator : Form
    {
        PolishCalculator polishCalculator;

        public RPNCalculator()
        {
            InitializeComponent();
            polishCalculator = new PolishCalculator();
            polishCalculator.clearAll();
            textBox1.Text = polishCalculator.returnDisplayValue()[0];
            textBox2.Text = polishCalculator.returnDisplayValue()[1];
            textBox3.Text = polishCalculator.returnDisplayValue()[2];
            textBox4.Text = polishCalculator.returnDisplayValue()[3];
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        private void Clear_Click(object sender, EventArgs e)
        {
            polishCalculator.clear();
            textBox1.Text = polishCalculator.returnDisplayValue()[0];
            textBox2.Text = polishCalculator.returnDisplayValue()[1];
            textBox3.Text = polishCalculator.returnDisplayValue()[2];
            textBox4.Text = polishCalculator.returnDisplayValue()[3];
        }

        private void AC_Click(object sender, EventArgs e)
        {
            polishCalculator.clearAll();
            textBox1.Text = polishCalculator.returnDisplayValue()[0];
            textBox2.Text = polishCalculator.returnDisplayValue()[1];
            textBox3.Text = polishCalculator.returnDisplayValue()[2];
            textBox4.Text = polishCalculator.returnDisplayValue()[3];
        }

        private void POP_Click(object sender, EventArgs e)
        {
            polishCalculator.pop();
            textBox1.Text = polishCalculator.returnDisplayValue()[0];
            textBox2.Text = polishCalculator.returnDisplayValue()[1];
            textBox3.Text = polishCalculator.returnDisplayValue()[2];
            textBox4.Text = polishCalculator.returnDisplayValue()[3];
        }

        private void SWAP_Click(object sender, EventArgs e)
        {
            polishCalculator.swap();
            textBox1.Text = polishCalculator.returnDisplayValue()[0];
            textBox2.Text = polishCalculator.returnDisplayValue()[1];
            textBox3.Text = polishCalculator.returnDisplayValue()[2];
            textBox4.Text = polishCalculator.returnDisplayValue()[3];
        }

        private void Inverse_Click(object sender, EventArgs e)
        {
            polishCalculator.inverse();
            textBox1.Text = polishCalculator.returnDisplayValue()[0];
            textBox2.Text = polishCalculator.returnDisplayValue()[1];
            textBox3.Text = polishCalculator.returnDisplayValue()[2];
            textBox4.Text = polishCalculator.returnDisplayValue()[3];
        }

        private void PlusMinus_Click(object sender, EventArgs e)
        {
            polishCalculator.plusMinus();
            textBox1.Text = polishCalculator.returnDisplayValue()[0];
            textBox2.Text = polishCalculator.returnDisplayValue()[1];
            textBox3.Text = polishCalculator.returnDisplayValue()[2];
            textBox4.Text = polishCalculator.returnDisplayValue()[3];
        }

        private void SQRT_Click(object sender, EventArgs e)
        {
            polishCalculator.sqrt();
            textBox1.Text = polishCalculator.returnDisplayValue()[0];
            textBox2.Text = polishCalculator.returnDisplayValue()[1];
            textBox3.Text = polishCalculator.returnDisplayValue()[2];
            textBox4.Text = polishCalculator.returnDisplayValue()[3];
        }

        private void button7_Click(object sender, EventArgs e)
        {
            polishCalculator.buildDisplayValue('7');
            textBox1.Text = polishCalculator.returnDisplayValue()[0];
            textBox2.Text = polishCalculator.returnDisplayValue()[1];
            textBox3.Text = polishCalculator.returnDisplayValue()[2];
            textBox4.Text = polishCalculator.returnDisplayValue()[3];
        }

        private void button8_Click(object sender, EventArgs e)
        {
            polishCalculator.buildDisplayValue('8');
            textBox1.Text = polishCalculator.returnDisplayValue()[0];
            textBox2.Text = polishCalculator.returnDisplayValue()[1];
            textBox3.Text = polishCalculator.returnDisplayValue()[2];
            textBox4.Text = polishCalculator.returnDisplayValue()[3];
        }

        private void button9_Click(object sender, EventArgs e)
        {
            polishCalculator.buildDisplayValue('9');
            textBox1.Text = polishCalculator.returnDisplayValue()[0];
            textBox2.Text = polishCalculator.returnDisplayValue()[1];
            textBox3.Text = polishCalculator.returnDisplayValue()[2];
            textBox4.Text = polishCalculator.returnDisplayValue()[3];
        }

        private void Divide_Click(object sender, EventArgs e)
        {
            polishCalculator.divide();
            textBox1.Text = polishCalculator.returnDisplayValue()[0];
            textBox2.Text = polishCalculator.returnDisplayValue()[1];
            textBox3.Text = polishCalculator.returnDisplayValue()[2];
            textBox4.Text = polishCalculator.returnDisplayValue()[3];
        }

        private void button4_Click(object sender, EventArgs e)
        {
            polishCalculator.buildDisplayValue('4');
            textBox1.Text = polishCalculator.returnDisplayValue()[0];
            textBox2.Text = polishCalculator.returnDisplayValue()[1];
            textBox3.Text = polishCalculator.returnDisplayValue()[2];
            textBox4.Text = polishCalculator.returnDisplayValue()[3];
        }

        private void button5_Click(object sender, EventArgs e)
        {
            polishCalculator.buildDisplayValue('5');
            textBox1.Text = polishCalculator.returnDisplayValue()[0];
            textBox2.Text = polishCalculator.returnDisplayValue()[1];
            textBox3.Text = polishCalculator.returnDisplayValue()[2];
            textBox4.Text = polishCalculator.returnDisplayValue()[3];
        }

        private void button6_Click(object sender, EventArgs e)
        {
            polishCalculator.buildDisplayValue('6');
            textBox1.Text = polishCalculator.returnDisplayValue()[0];
            textBox2.Text = polishCalculator.returnDisplayValue()[1];
            textBox3.Text = polishCalculator.returnDisplayValue()[2];
            textBox4.Text = polishCalculator.returnDisplayValue()[3];
        }

        private void Multiply_Click(object sender, EventArgs e)
        {
            polishCalculator.multiply();
            textBox1.Text = polishCalculator.returnDisplayValue()[0];
            textBox2.Text = polishCalculator.returnDisplayValue()[1];
            textBox3.Text = polishCalculator.returnDisplayValue()[2];
            textBox4.Text = polishCalculator.returnDisplayValue()[3];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            polishCalculator.buildDisplayValue('1');
            textBox1.Text = polishCalculator.returnDisplayValue()[0];
            textBox2.Text = polishCalculator.returnDisplayValue()[1];
            textBox3.Text = polishCalculator.returnDisplayValue()[2];
            textBox4.Text = polishCalculator.returnDisplayValue()[3];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            polishCalculator.buildDisplayValue('2');
            textBox1.Text = polishCalculator.returnDisplayValue()[0];
            textBox2.Text = polishCalculator.returnDisplayValue()[1];
            textBox3.Text = polishCalculator.returnDisplayValue()[2];
            textBox4.Text = polishCalculator.returnDisplayValue()[3];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            polishCalculator.buildDisplayValue('3');
            textBox1.Text = polishCalculator.returnDisplayValue()[0];
            textBox2.Text = polishCalculator.returnDisplayValue()[1];
            textBox3.Text = polishCalculator.returnDisplayValue()[2];
            textBox4.Text = polishCalculator.returnDisplayValue()[3];
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            polishCalculator.subtract();
            textBox1.Text = polishCalculator.returnDisplayValue()[0];
            textBox2.Text = polishCalculator.returnDisplayValue()[1];
            textBox3.Text = polishCalculator.returnDisplayValue()[2];
            textBox4.Text = polishCalculator.returnDisplayValue()[3];
        }

        private void Plus_Click(object sender, EventArgs e)
        {
            polishCalculator.plus();
            textBox1.Text = polishCalculator.returnDisplayValue()[0];
            textBox2.Text = polishCalculator.returnDisplayValue()[1];
            textBox3.Text = polishCalculator.returnDisplayValue()[2];
            textBox4.Text = polishCalculator.returnDisplayValue()[3];
        }

        private void Enter_Click(object sender, EventArgs e)
        {
            polishCalculator.enter();
            textBox1.Text = polishCalculator.returnDisplayValue()[0];
            textBox2.Text = polishCalculator.returnDisplayValue()[1];
            textBox3.Text = polishCalculator.returnDisplayValue()[2];
            textBox4.Text = polishCalculator.returnDisplayValue()[3];
        }

        private void Point_Click(object sender, EventArgs e)
        {
            polishCalculator.buildDisplayValue('.');
            textBox1.Text = polishCalculator.returnDisplayValue()[0];
            textBox2.Text = polishCalculator.returnDisplayValue()[1];
            textBox3.Text = polishCalculator.returnDisplayValue()[2];
            textBox4.Text = polishCalculator.returnDisplayValue()[3];
        }

        private void buttonZero_Click(object sender, EventArgs e)
        {
            polishCalculator.buildDisplayValue('0');
            textBox1.Text = polishCalculator.returnDisplayValue()[0];
            textBox2.Text = polishCalculator.returnDisplayValue()[1];
            textBox3.Text = polishCalculator.returnDisplayValue()[2];
            textBox4.Text = polishCalculator.returnDisplayValue()[3];
        }

        private void Exponetial_Click(object sender, EventArgs e)
        {
            polishCalculator.exponent();
            textBox1.Text = polishCalculator.returnDisplayValue()[0];
            textBox2.Text = polishCalculator.returnDisplayValue()[1];
            textBox3.Text = polishCalculator.returnDisplayValue()[2];
            textBox4.Text = polishCalculator.returnDisplayValue()[3];
        }
    }
}
