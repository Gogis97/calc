using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Calculator : Form
    {
        String currentEntry = "";
        public Calculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;

        }
        private void button17_Click(object sender, EventArgs e)
        {
            currentEntry += "0";
            richTextBox1.Text += "0";
        }
        private void button13_Click(object sender, EventArgs e)
        {
            currentEntry += "1";
            richTextBox1.Text += "1";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            currentEntry += "2";
            richTextBox1.Text += "2";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            currentEntry += "3";
            richTextBox1.Text += "3";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            currentEntry += "4";
            richTextBox1.Text += "4";
        }
            

        private void button10_Click(object sender, EventArgs e)
        {
            currentEntry += "5";
            richTextBox1.Text += "5";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            currentEntry += "6";
            richTextBox1.Text += "6";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            currentEntry += "7";
            richTextBox1.Text += "7";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            currentEntry += "8";
            richTextBox1.Text += "8";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            currentEntry += "9";
            richTextBox1.Text += "9";
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            currentEntry = "";
            richTextBox1.Text = "";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            currentEntry += ",";
            richTextBox1.Text  += ",";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            currentEntry = "";
            richTextBox1.Text += "/";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            currentEntry = "";
            richTextBox1.Text += "*";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            currentEntry = "";
            richTextBox1.Text += "-";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            currentEntry = "";
            richTextBox1.Text += "+";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = Convert.ToString(Calculator.Evaluate(richTextBox1.Text));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text.Substring(0, richTextBox1.Text.Length - currentEntry.Length) + Convert.ToString(Convert.ToDouble(currentEntry) / 100);
            currentEntry = Convert.ToString(Convert.ToDouble(currentEntry) / 100);

        }

        static double Evaluate(string expression)
        {
            expression = String.Join(".", expression.Split(','));
            var loDataTable = new DataTable();
            var loDataColumn = new DataColumn("Eval", typeof(double), expression);
            loDataTable.Columns.Add(loDataColumn);
            loDataTable.Rows.Add(0);
            return (double)(loDataTable.Rows[0]["Eval"]);
        }
    }
}
