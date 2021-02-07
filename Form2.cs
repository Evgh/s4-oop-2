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
        List<Adress> _adresses;

        public Form2(Form1 parent, List<Adress> adresses)
        {
            InitializeComponent();
            _parent = parent;
            _adresses = adresses;

            InitializeDataGridViewAdresses();
        }

        private void InitializeDataGridViewAdresses()
        {
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = _adresses;
            dataGridViewAdresses.DataSource = bindingSource;
            dataGridViewAdresses.Columns["MyToString"].Visible = false;
        }

        private void buttonAddAdress_Click(object sender, EventArgs e)
        { 
            try
            {
                _adresses.Add( new Adress() 
                { 
                    Country = textBoxCountry.Text, 
                    City = textBoxCity.Text, 
                    District = textBoxDistrict.Text, 
                    Street = textBoxStreet.Text, 
                    HouseNumber = textBoxHouseNum.Text, 
                    FlatNumber = int.Parse(maskedTextBoxFlatNum.Text)
                    
                }
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
