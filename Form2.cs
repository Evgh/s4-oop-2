using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace s4_oop_2
{
    public partial class Form2 : Form
    {
        Form1 _parent;

        public Form2(Form1 parent)
        {
            InitializeComponent();
            _parent = parent;

            InitializeDataGridViewAdresses();
        }

        private void InitializeDataGridViewAdresses()
        {
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = Adress.adressPool;
            dataGridViewAdresses.DataSource = bindingSource;
            dataGridViewAdresses.Columns["MyToString"].Visible = false;
            dataGridViewAdresses.Columns["ID"].Visible = false;
        }

        private void buttonAddAdress_Click(object sender, EventArgs e)
        { 
            try
            {
                Adress.Add(
                    textBoxCountry.Text,
                    textBoxCity.Text,
                    textBoxDistrict.Text,
                    textBoxStreet.Text,
                    textBoxHouseNum.Text,
                    int.Parse(maskedTextBoxFlatNum.Text)
                    );
                maskedTextBoxFlatNum.BackColor = System.Drawing.SystemColors.Window;
            }
            catch (System.FormatException ex)
            {
                MessageBox.Show(ex.Message);
                maskedTextBoxFlatNum.BackColor = System.Drawing.Color.Salmon;
            }

            InitializeDataGridViewAdresses();
            _parent.InitializeListBoxAdress();
        }

        private void dataGridViewAdresses_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        {
            _parent.InitializeListBoxAdress();
        }



    }
}
