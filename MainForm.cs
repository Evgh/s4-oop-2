using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Linq;
using Newtonsoft.Json;


namespace s4_oop_2
{

    public partial class MainForm : Form
    {
        public List<Flat> _flats;
        internal SaveFileDialog SaveDialog { get => saveFileDialog1; }
        internal OpenFileDialog OpenDiialog { get => openFileDialog1; }


        public MainForm() : this (new List<Flat> { })
        {
        }

        public MainForm(List<Flat> flats)
        {
            InitializeComponent();
            _flats = flats;

            InitializeDataGridView1();
            InitializeListBoxAdress();
            AddComboBoxColumn();
        }

        internal void InitializeDataGridView1()
        {
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = _flats;
            dataGridView1.DataSource = bindingSource;

            if (_flats != null)
            {
                dataGridView1.Columns["AdressId"].Visible = false;
                dataGridView1.Columns["FlatAdress"].Visible = false;
                DataGridViewColumn columnAdressLast = dataGridView1.Columns[dataGridView1.Columns.Count - 1];
                DataGridViewColumn columnAdressFirst = dataGridView1.Columns[0];
                columnAdressLast.AutoSizeMode = columnAdressFirst.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }
        }

        internal void AddComboBoxColumn()
        {
            // Функционал, чтобы редактировать адреса через выпадающий список Combobox  
            DataGridViewComboBoxColumn column = new DataGridViewComboBoxColumn();
            column.HeaderText = "Adress";
            column.Width = 300;
            //data sourse
            BindingSource comboboxSource = new BindingSource();
            comboboxSource.DataSource = Adress.adressPool;
            column.DataSource = comboboxSource;

            // отображается в колонке
            column.DisplayMember = "MyToString";
            // свойство, возвращающее ссылку объекта на сам себя (здесь тип Adress)
            column.ValueMember = "Self";
            // свойство типа Adress в объекте Flat
            column.DataPropertyName = "FlatAdress";
            dataGridView1.Columns.Add(column);
        }

        internal void InitializeListBoxAdress()
        {
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = Adress.adressPool;
            listBoxAdress.DataSource = bindingSource;
            listBoxAdress.DisplayMember = "MyToString";
            listBoxAdress.ValueMember = "FlatNumber";
        }

        FlatArgs MyFlatArgs
        {
            get
            {
                return new FlatArgs
                {
                    owner = maskedTextBoxOwner.Text,
                    residentAmount = trackBarResidentAmount.Value,
                    area = int.Parse(maskedTextBoxArea.Text),
                    day = dateTimePickerDay.Value,
                    hasKitchen = checkBoxHasKitchen.Checked,
                    hasBathroom = checkBoxHasBathroom.Checked,
                    hasRestroom = checkBoxHasRestroom.Checked,
                    hasBasement = checkBoxHasBasement.Checked,
                    hasBalcony = checkBoxHasBalcony.Checked,
                    adress = listBoxAdress.SelectedItem as Adress
                };
            }
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
            // try/catch обрабатывает случай, если площадь не введена
            try
            {
                var flat = new Flat(MyFlatArgs);
                var results = new List<ValidationResult> { };
                var context = new ValidationContext(flat);
                // валидация 
                if (!Validator.TryValidateObject(flat, context, results, true))
                {
                    List<int> invalidIndexex = new List<int> { };
                    StringBuilder message = new StringBuilder("");
                    
                    foreach (var error in results)
                    {
                        message.Append(error.ErrorMessage);
                        message.Append('\n');
                        // получаем таб-индекс элемента из сообщения об ошибке (индексы прописаны вручную)
                        invalidIndexex.Add(int.Parse(error.ErrorMessage.Substring(0, 1)));
                    }

                    //// перекрашиваем поля ввода с некорректными данными
                    foreach (Control control in panel1.Controls)
                    {
                        for (int i = 0; i < invalidIndexex.Count; i++)
                        {
                            if (control.TabIndex == invalidIndexex[i])
                            {
                                control.BackColor = System.Drawing.Color.Salmon;
                                break;
                            }
                            control.BackColor = System.Drawing.SystemColors.Window;
                        }                        
                    }

                    MessageBox.Show(message.ToString());
                }
                else
                {
                    _flats.Add(flat);
                    maskedTextBoxArea.BackColor = maskedTextBoxOwner.BackColor = System.Drawing.SystemColors.Window;

                    RoomEditForm roomEditor = new RoomEditForm(_flats[_flats.Count - 1].Id, this);
                    roomEditor.Show();
                }
            }
            catch (System.FormatException ex)
            {
                MessageBox.Show(ex.Message);
                maskedTextBoxArea.BackColor = System.Drawing.Color.Salmon;
            }
            InitializeDataGridView1();            
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {

        }

        private void buttonAdressesMenu_Click(object sender, EventArgs e)
        {
            AdressEditForm form = new AdressEditForm(this);
            form.Show();
        }

        private void buttonSerialize_Click(object sender, EventArgs e)
        {

            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            string path = saveFileDialog1.FileName;
            XmlSerializer serializer = new XmlSerializer(_flats.GetType());
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                serializer.Serialize(fs, _flats);
            }
            MessageBox.Show("Файл сохранен");
        }
        private void buttonDeserialize_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            string path = openFileDialog1.FileName;
            XmlSerializer serializer = new XmlSerializer(_flats.GetType());
            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                _flats = (List<Flat>)serializer.Deserialize(fs);
            }

            // костыль, поскольку я усложнила себе жизнь и сделала адреса хранящимися в пуле
            // собственно, объекты-адреса не сериализуются, они просто хранятся в памяти, а каждая квартира получает даже не ссылку на свой адрес, а id адреса
            // и по этому id квартира работает со ссылкой на адрес через пул адресов
            // возможна ситуация, когда объект десериализуется, и у него будет ид на адрес, которого не существует
            foreach (var flat in _flats)
            {
                if (flat.AdressId > Adress.adressPool.Count - 1)
                {
                    flat.AdressId = 0;
                }
            }

            InitializeDataGridView1();
        }

        private void buttonRooms_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                RoomEditForm form = new RoomEditForm(int.Parse(row.Cells[0].Value.ToString()), this);
                form.Show();
            }
        }

        private void buttonСount_Click(object sender, EventArgs e)
        {
            string message = "";
            if (dataGridView1.SelectedRows.Count == 1)
            {
                int id = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                Flat theFlat = _flats.Find((f) => { return f.Id == id; });

                message = $"Стоимость квартиры {theFlat?.GetPrice()} белорусских рублей";
            }
            else
            {
                message = "Выделите 1 строку в таблице";
            }

            MessageBox.Show(message);
        }

        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }


        ////////////////////////////////////////////////// пункт меню "Файл"

        // cериализация xml
        private void XMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "XML files(*.xml)|*.xml|All files|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            string path = saveFileDialog1.FileName;
            XmlSerializer serializer = new XmlSerializer(typeof(List<Flat>));
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                serializer.Serialize(fs, _flats);
            }
            MessageBox.Show("Файл сохранен");
        }

        private void XMLToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "XML files(*.xml)|*.xml";
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            string path = openFileDialog1.FileName;
            XmlSerializer serializer = new XmlSerializer(typeof(List<Flat>));
            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                _flats = (List<Flat>)serializer.Deserialize(fs);
            }

            // костыль, поскольку я усложнила себе жизнь и сделала адреса хранящимися в пуле
            // собственно, объекты-адреса не сериализуются, они просто хранятся в памяти, а каждая квартира получает даже не ссылку на свой адрес, а id адреса
            // и по этому id квартира работает со ссылкой на адрес через пул адресов
            // возможна ситуация, когда объект десериализуется, и у него будет ид на адрес, которого не существует
            foreach (var flat in _flats)
            {
                if (flat.AdressId > Adress.adressPool.Count - 1)
                {
                    flat.AdressId = 0;
                }
            }

            InitializeDataGridView1();
        }

        // json
        private void jSONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Java Script Object Notation(*.json)|*.json|All files|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            string path = saveFileDialog1.FileName;
            using (StreamWriter sw = new StreamWriter(path, false))
            {
                sw.WriteLine(JsonConvert.SerializeObject(_flats, Newtonsoft.Json.Formatting.Indented));
            }
            MessageBox.Show("Файл сохранен");
        }

        private void jSONToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Java Script Object Notation(*.json)|*.json";
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            string path = openFileDialog1.FileName;
            using(StreamReader sr = new StreamReader(path)) 
            {
                _flats = JsonConvert.DeserializeObject<List<Flat>>(sr.ReadToEnd()); 
            }
            
            if (_flats != null)
            {
                foreach (var flat in _flats)
                {
                    if (flat.AdressId > Adress.adressPool.Count - 1)
                    {
                        flat.AdressId = 0;
                    }
                }
            }
            InitializeDataGridView1();
        }

        private void рассчитатьСтоимостьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "";
            if (dataGridView1.SelectedRows.Count == 1)
            {
                string selectedId = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                int id = int.Parse(selectedId);
                Flat selectedFlat = _flats.Find((f) => { return f.Id == id; });

                if (selectedFlat != null)
                {
                    message = $"Стоимость квартиры {selectedFlat.GetPrice()} белорусских рублей";
                }
                else
                {
                    message = "Ошибка: квартира не найдена";
                }
            }
            else
            {
                message = "Выделите 1 строку в таблице";
            }

            MessageBox.Show(message);
        }

        private void очиститьТаблицуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _flats.Clear();
            InitializeDataGridView1();
        }

        ////////////////////////////////////////////////// меню "Поиск"

        private void типколичествоКомнатToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new SearchForm(new SearchFormArgs() { type = true }, this)).Show();
        }
        private void годЗаселенияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new SearchForm(new SearchFormArgs() { year = true }, this)).Show();
        }

        private void районToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new SearchForm(new SearchFormArgs() { district = true }, this)).Show();
        }

        private void городToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new SearchForm(new SearchFormArgs() { city = true }, this)).Show();

        }
        private void выбратьНесколькоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new SearchForm(new SearchFormArgs() {}, this)).Show();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {            
        }

        ////////////////////////////////////////////////// О программе 
        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа 'Квартиры' v.2.0 (с) Касперович Е.Н.");
        }

        ///////////////////////////////////////////////// Сортировка
        private void площадиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sorted = from flat in _flats
                         orderby flat.Area
                         select flat;
            _flats = sorted.ToList<Flat>();
            InitializeDataGridView1();
        }

        private void количествуКомнатToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sorted = from flat in _flats
                         orderby flat.RoomAmount
                         select flat;
            _flats = sorted.ToList<Flat>();
            InitializeDataGridView1();
        }

        private void ценеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sorted = from flat in _flats
                         orderby flat.GetPrice()
                         select flat;
            _flats = sorted.ToList<Flat>();
            InitializeDataGridView1();
        }
    }
}