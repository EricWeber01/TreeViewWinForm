using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Media;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TreeViewWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.SelectedIndex = 0;
            radioButton1.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text != "" && maskedTextBox2.Text != "" && maskedTextBox3.Text != "" && maskedTextBox4.Text != "")
            {
                switch (comboBox1.SelectedIndex)
                {
                    case 0:
                        {
                            Button bt = new Button();
                            bt.Text = "Button";
                            bt.Location = new Point(int.Parse(maskedTextBox1.Text), int.Parse(maskedTextBox3.Text));
                            bt.Size = new Size(int.Parse(maskedTextBox2.Text), int.Parse(maskedTextBox4.Text));
                            if (radioButton1.Checked) { groupBox2.Controls.Add(bt); }
                            else if (radioButton2.Checked) { panel1.Controls.Add(bt); }
                        }
                        break;
                    case 1:
                        {
                            Label bt = new Label();
                            bt.Text = "Label";
                            bt.Location = new Point(int.Parse(maskedTextBox1.Text), int.Parse(maskedTextBox3.Text));
                            bt.Size = new Size(int.Parse(maskedTextBox2.Text), int.Parse(maskedTextBox4.Text));
                            if (radioButton1.Checked) { groupBox2.Controls.Add(bt); }
                            else if (radioButton2.Checked) { panel1.Controls.Add(bt); }
                        }
                        break;
                    case 2:
                        {
                            TextBox bt = new TextBox();
                            bt.Text = "TextBox";
                            bt.Location = new Point(int.Parse(maskedTextBox1.Text), int.Parse(maskedTextBox3.Text));
                            bt.Size = new Size(int.Parse(maskedTextBox2.Text), int.Parse(maskedTextBox4.Text));
                            if (radioButton1.Checked) { groupBox2.Controls.Add(bt); }
                            else if (radioButton2.Checked) { panel1.Controls.Add(bt); }
                        }
                        break;
                }
            }
        }
    }
}
