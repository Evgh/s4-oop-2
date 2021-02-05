using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace s4_oop_2
{
    public partial class Form1 : Form
    {
        List<Flat> flats;

        public Form1()
        {
            InitializeComponent();
            flats = new List<Flat> { new Flat() };
            dataGridView1.DataSource = flats;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void radioButtonGoodsDefault_CheckedChanged(object sender, EventArgs e)
        {
            foreach (var control in panel2.Controls)
            {
                if (control is CheckBox)
                {
                    var checkBox = control as CheckBox;
                    checkBox.AutoCheck = false;

                    if (checkBox.Name == "checkBoxHasBasement" || checkBox.Name == "checkBoxHasBalcony")
                    {
                        checkBox.CheckState = CheckState.Unchecked;
                    }
                    else
                    {
                        checkBox.CheckState = CheckState.Indeterminate;
                    }
                }
            }
        }

        private void radioButtonGoodsManual_CheckedChanged(object sender, EventArgs e)
        {
            foreach (var control in panel2.Controls)
            {
                if (control is CheckBox)
                {
                    var checkBox = control as CheckBox;
                    checkBox.AutoCheck = true;

                    if (checkBox.CheckState == CheckState.Indeterminate)
                    {
                        checkBox.CheckState = CheckState.Checked;
                    }

                }
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            flats.Add(new Flat());
        }
    }
}
