using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataTable history = new DataTable();

        private void historyTable()
        {
            history.Columns.Add("Operation");
            history.Columns.Add("Result");
        }
        double first, second, result;
        string operation;
        bool isMod = true;
        private void calculation(string op)
        {
            try
            {
                first = Convert.ToDouble(textBox1.Text);
                second = Convert.ToDouble(textBox2.Text);
                switch (op)
                {
                    case "+":
                        operation = "+";
                        result = first + second;
                        break;
                    case "-":
                        operation = "-";
                        result = first - second;
                        break;
                    case "*":
                        operation = "*";
                        result = first * second;
                        break;
                    case "/":
                        operation = "/";
                        result = first / second;
                        break;
                    case "%":
                        operation = "%";
                        result = first % second;
                        break;
                }
                textBox3.Text = Convert.ToString(result);
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show(ex.Message + "\nDivident Can't be Zero", "Alert");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alert");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "" && textBox2.Text != "")
            {
                calculation("+");
            }
            else
            {
                MessageBox.Show("Please Fill all Input Fields", "Alert");
            }
            
        }

        private void mul_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                calculation("*");
            }
            else
            {
                MessageBox.Show("Please Fill all Input Fields", "Alert");
            }
        }

        private void div_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                calculation("/");
            }
            else
            {
                MessageBox.Show("Please Fill all Input Fields", "Alert");
            }
        }

        private void mod_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                calculation("%");
            }
            else
            {
                MessageBox.Show("Please Fill all Input Fields", "Alert");
            }
        }

        private void addresult_Click(object sender, EventArgs e)
        {
            history.Rows.Add(operation, result);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            historyTable();
            listBox1.DataSource = history;
            listBox1.DisplayMember = "result";
            if (isMod)
            {
                showMod.Checked = true;
                hideMod.Checked = false;
            }
            else
            {
                showMod.Checked = false;
                hideMod.Checked = true;
            }
        }

        private void clearall_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void deleteselected_Click(object sender, EventArgs e)
        {
            if (history.Rows.Count > 0)
            {
                history.Rows[listBox1.SelectedIndex].Delete();
            }
            else
            {
                MessageBox.Show("Empty List Box", "Alert");
            }
        }

        private void clearhistory_Click(object sender, EventArgs e)
        {
            if (history.Rows.Count > 0)
            {
                for(int i=(history.Rows.Count-1); i>=0; i--)
                {
                    history.Rows[i].Delete();
                }
            }
            else
            {
                MessageBox.Show("Empty List Box", "Alert");
            }
        }

        private void hideMul_CheckedChanged(object sender, EventArgs e)
        {
            if (hideMul.Checked)
            {
                mul.Visible = false;
            }
            else
            {
                mul.Visible = true;
            }
        }

        private void hideDiv_CheckedChanged(object sender, EventArgs e)
        {
            if (hideDiv.Checked)
            {
                div.Visible = false;
            }
            else
            {
                div.Visible = true;
            }
        }

        private void hideMod_CheckedChanged(object sender, EventArgs e)
        {
            if (hideMod.Checked)
            {
                mod.Visible = false;
            }
        }

        private void showMod_CheckedChanged(object sender, EventArgs e)
        {
            if (showMod.Checked)
            {
                mod.Visible = true;
            }
        }


        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void sub_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                calculation("-");
            }
            else
            {
                MessageBox.Show("Please Fill all Input Fields", "Alert");
            }
        }
    }
}
