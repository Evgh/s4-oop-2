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
    public partial class AdressEditForm : Form
    {
        MainForm _parent;

        public AdressEditForm(MainForm parent)
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

        private void ChangeControlsColors(List<int> indexes)
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox || control is MaskedTextBox)
                {
                    if (indexes.Count > 0)
                    {
                        for (int i = 0; i < indexes.Count; i++)
                        {
                            if (control.TabIndex == indexes[i])
                            {
                                control.BackColor = System.Drawing.Color.Salmon;
                                break;
                            }
                            control.BackColor = System.Drawing.SystemColors.Window;
                        }
                    }
                    else
                    {
                        control.BackColor = System.Drawing.SystemColors.Window;
                    }
                }
            }
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
                // костыль, чтобы поля ввода перекрашивались обратно при правильных значениях 
                ChangeControlsColors(new List<int> {});
            }
            catch (System.FormatException ex)
            {
                MessageBox.Show(ex.Message);
                maskedTextBoxFlatNum.BackColor = System.Drawing.Color.Salmon;
            }
            catch (Adress.AdressValidationException ex)
            {
                MessageBox.Show(ex.Message);
                ChangeControlsColors(ex.ControlsIndexex);

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
