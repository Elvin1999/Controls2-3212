using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controls2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.ForeColor = Color.LightGray;

            this.BackColor= Color.FromArgb(0, 206,203);



        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            MessageBox.Show($"This text : {text} send to the client successfully");
        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            if(textBox1.Text =="some message")
            {
                textBox1.Text=string.Empty;
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == string.Empty)
            {
                textBox1.Text = "some message";
                textBox1.ForeColor = Color.LightGray;
            }
        }

        private void passwordTxtb_KeyPress(object sender, KeyPressEventArgs e)
        {
            string text = passwordTxtb.Text.Trim();
            if(text.Length>0 && text.Length <= 6)
            {
                infoLbl.Text = "your pass is so weak";
                infoLbl.ForeColor = Color.Red;
            }
            else if(text.Length>=7 && text.Length <= 14)
            {
                infoLbl.Text = "your pass is so normal";
                infoLbl.ForeColor = Color.Orange;
            }
            else if((text.Length >= 15 && text.Length <= 20))
            {
                infoLbl.Text = "your pass is so strong";
                infoLbl.ForeColor = Color.Green;
                passwordTxtb.PasswordChar = '\0';
            }
        }

        private void undoBtn_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void redoBtn_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void cutBtn_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void copyBtn_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pasteBtn_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(richTextBox1.SelectedText);
            //richTextBox1.SelectionColor = Color.Green;
            //richTextBox1.SelectionFont = new Font("Comic Sans MS", 20, FontStyle.Bold | FontStyle.Italic);
            //richTextBox1.ForeColor = Color.Black;


            this.BackColor = Color.Green;
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            richTextBox1.Text = monthCalendar1.SelectionStart.ToString();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            richTextBox1.Text=dateTimePicker1.Value.ToString();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox1.Text = "C# I know";
            }
            else
            {
                checkBox1.Text = "C# I do not Know";
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
            if (radioButton1.Checked)
            {
                radioButton1.Text = "Visa Selected";
                radioButton2.Text = "Master";
            }
            else
            {
                radioButton1.Text = "Visa";
                radioButton2.Text = "Master Selected";
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            foreach (var item in groupBox2.Controls)
            {
                if(item is RadioButton rb)
                {
                    if (rb.Checked)
                    {
                        rb.BackColor=Color.Red;
                    }
                    else
                    {
                        rb.BackColor = Color.Transparent;
                    }
                }
            }
        }
    }
}
