﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Linq;
using Newtonsoft.Json;


namespace s4_oop_2
{

    public partial class MainForm : Form, IBindingForm
    {
        IBindingList primary;
        IBindingList secondary;
        public IBindingList PrimarySource { get => primary; }
        public IBindingList SecondarySource { get => secondary; }

        internal SaveFileDialog SaveDialog { get => saveFileDialog1; }
        internal OpenFileDialog OpenDiialog { get => openFileDialog1; }

        /// <summary>
        /// Для передачи данных из полей ввода в конструктор Flat
        /// </summary>
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

        public MainForm()
        {   
            InitializeComponent();
            InitializeShortcutKeys();
            InitializeTimer();
        }
        public Form ToForm()
        {
            return this;
        }

        public void InitializePrimarySource(IBindingList source)
        {
            primary = source;
            dataGridView1.DataSource = PrimarySource;
            AddComboBoxColumn();

            if (PrimarySource != null)
            {
                dataGridView1.Columns["AdressId"].Visible = false;
                dataGridView1.Columns["FlatAdress"].Visible = false;
                DataGridViewColumn columnAdressLast = dataGridView1.Columns[dataGridView1.Columns.Count - 1];
                DataGridViewColumn columnAdressFirst = dataGridView1.Columns[0];
                columnAdressLast.AutoSizeMode = columnAdressFirst.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }
        }

        public void InitializeSecondarySource(IBindingList source)
        {
            secondary = source;
            listBoxAdress.DataSource = SecondarySource;
            listBoxAdress.DisplayMember = "MyToString";
            listBoxAdress.ValueMember = "FlatNumber";
        }
        ////////////////////////////////////////////////////////////////////// методы, инициализирующие определенные компоненты
        /// <summary>
        /// Метод добавляет колонку "Адрес", которую можно редактировать адреса через выпадающий список Combobox 
        /// </summary>
        private void AddComboBoxColumn()
        {
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

        internal void InitializeShortcutKeys()
        {
            firstSaveJSONToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            firstOpenJSONToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            searchManualToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.F;
        }

        internal void InitializeTimer()
        {
            System.Timers.Timer dateTimeTimer = new System.Timers.Timer();
            dateTimeTimer.Elapsed += new System.Timers.ElapsedEventHandler(aTimer_Elapsed);
            dateTimeTimer.Interval = 1000;   //here you can set your interval
            dateTimeTimer.Start();
        }
        void aTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            toolStripStatusLabelDateTime.Text = DateTime.Now.ToString();
        }


        //////////////////////////////////////////////////////////////////////
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
            // ошибка возникает в MyFlatArgs
            try
            {
                // Паттерн Builder
                FlatBuilder fb;
                if (checkBoxRundomRooms.Checked)
                {
                    fb = new SuperFlatBuilder(MyFlatArgs);
                }
                else
                { 
                   fb = new SimpleFlatBuilder(MyFlatArgs);
                }
                var flat = FlatDirector.CreateFlat(fb);
                
                // для валидации
                var results = new List<ValidationResult> { };
                var context = new ValidationContext(flat);

                // валидация 
                if (!Validator.TryValidateObject(flat, context, results, true))
                {
                    OnInvalidValidation(results);
                }
                else
                {
                    // если валидация успешна
                    PrimarySource.Add(flat);
                    maskedTextBoxArea.BackColor = maskedTextBoxOwner.BackColor = System.Drawing.SystemColors.Window;

                    RoomEditForm roomEditor = new RoomEditForm(((IFlat)PrimarySource[PrimarySource.Count - 1]).Id, this);
                    roomEditor.Show();
                }
            }
            catch (System.FormatException ex)
            {
                MessageBox.Show(ex.Message);
                maskedTextBoxArea.BackColor = System.Drawing.Color.Salmon;
            }
        }

        private void OnInvalidValidation(List<ValidationResult> results)
        {
            List<int> invalidIndexes = new List<int> { };
            StringBuilder message = new StringBuilder("");

            foreach (var error in results)
            {
                message.Append(error.ErrorMessage);
                message.Append('\n');
                // получаем таб-индекс элемента из сообщения об ошибке (индексы прописаны вручную)
                invalidIndexes.Add(int.Parse(error.ErrorMessage.Substring(0, 1)));
            }

            //// перекрашиваем поля ввода с некорректными данными
            ColorInputs(invalidIndexes);
            MessageBox.Show(message.ToString());
        }

        /// <summary>
        /// Перекрашивает в цвет Salmon поля ввода, в которых введены некорректные значения
        /// </summary>
        /// <param name="invalidIndexes"> Таб-индексы элементов управления, которые надо перекрасить </param>
        private void ColorInputs(List<int> invalidIndexes)
        {
            foreach (Control control in panel1.Controls)
            {
                for (int i = 0; i < invalidIndexes.Count; i++)
                {
                    if (control.TabIndex == invalidIndexes[i])
                    {
                        control.BackColor = System.Drawing.Color.Salmon;
                        break;
                    }
                    control.BackColor = System.Drawing.SystemColors.Window;
                }
            }
        }

        //////////////////////////////////////////////////////////////////////

        private void buttonAdressesMenu_Click(object sender, EventArgs e)
        {
            AdressEditForm form = new AdressEditForm(this);
            form.Show();
        }

        ////////////////////////////////////////////////// пункт меню "Файл"
         
        // Сериализация
        class Converter : JsonConverter
        {
            public override bool CanConvert(Type objectType)
            {
                serializer.Serialize(fs, Flats);
                return (objectType == typeof(IFlat));
            }
            public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
            {
                serializer.Serialize(writer, value, typeof(SimpleFlat));
            }

            // костыль, поскольку я усложнила себе жизнь и сделала адреса хранящимися в пуле
            // собственно, объекты-адреса не сериализуются, они просто хранятся в памяти, а каждая квартира получает даже не ссылку на свой адрес, а id адреса
            // и по этому id квартира работает со ссылкой на адрес через пул адресов
            // возможна ситуация, когда объект десериализуется, и у него будет ид на адрес, которого не существует
            foreach (var flat in Flats)
            {
                if (flat.AdressId > Adress.adressPool.Count - 1)
                {
                    flat.AdressId = 0;
                }
            public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
            {
                return serializer.Deserialize(reader, typeof(SimpleFlat)); ;
            }
        }

        private void saveJSONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Java Script Object Notation(*.json)|*.json|All files|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            var settings = new JsonSerializerSettings();
            settings.Converters.Add(new Converter());

            string path = saveFileDialog1.FileName;
            using (StreamWriter sw = new StreamWriter(path, false))
            {
                sw.WriteLine(JsonConvert.SerializeObject(PrimarySource, Newtonsoft.Json.Formatting.Indented, settings));
            }
            MessageBox.Show("Файл сохранен");
        }

        private void deserializejSONToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Java Script Object Notation(*.json)|*.json";
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            var settings = new JsonSerializerSettings();
            settings.Converters.Add(new Converter());

            string path = openFileDialog1.FileName;
            using(StreamReader sr = new StreamReader(path)) 
            {
                Flats.Clear();
                foreach(var flat in JsonConvert.DeserializeObject<MyBindingSourse>(sr.ReadToEnd()))
                {
                    Flats.Add(flat);
                }
                //InitializeDataGridView1();
            using (StreamReader sr = new StreamReader(path))
            {
                PrimarySource.Clear();
                foreach (var flat in JsonConvert.DeserializeObject <SortableBindingList<IFlat>>(sr.ReadToEnd(), settings))
                {
                    PrimarySource.Add(flat);
                }
            }
            
            if (PrimarySource != null)
            {
                foreach (IFlat flat in PrimarySource)
                { 
                    if (flat.AdressId > Adress.adressPool.Count - 1)
                    {
                        flat.AdressId = 0;
                    }
                }
            }
        }
        
        // Узнать стоимость квартиры
        private void GetPriceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "";
            if (dataGridView1.SelectedRows.Count == 1)
            {
                string selectedId = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                int id = int.Parse(selectedId);
                
                IFlat selectedFlat = PrimarySource.OfType<IFlat>().Where((f) => f.Id == id).ToList()[0];

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

        // Очистить все
        private void ClearAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrimarySource.Clear();
        }

        ////////////////////////////////////////////////// меню "Поиск"

        private void seachRoomAmountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new SearchForm(new SearchFormArgs() { type = true }, this)).Show();
        }
        private void searchYearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new SearchForm(new SearchFormArgs() { year = true }, this)).Show();
        }

        private void searchDistrictToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new SearchForm(new SearchFormArgs() { district = true }, this)).Show();
        }

        private void searchCityStripMenuItem_Click(object sender, EventArgs e)
        {
            (new SearchForm(new SearchFormArgs() { city = true }, this)).Show();

        }
        private void searchManualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new SearchForm(new SearchFormArgs() {}, this)).Show();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {            
        }

        ////////////////////////////////////////////////// О программе 
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа 'Квартиры' v.2.0 (с) Касперович Е.Н.");
        }

        ///////////////////////////////////////////////// Сортировка
        private void sortAreaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //DataGridViewColumn column = dataGridView1.Columns["Area"];
            //dataGridView1.Sort(column, ListSortDirection.Ascending);
        }

        private void sortRoomAmountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //var sorted = from flat in _flats
            //             orderby flat.RoomAmount
            //             select flat;
            //_flats = sorted.ToList();
            //InitializeDataGridView1();
        }

        private void sortPriceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //var sorted = from flat in _flats
            //             orderby flat.GetPrice()
            //             select flat;
            //_flats = sorted.ToList();
            //InitializeDataGridView1();
        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButtonDeleteRow_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.Remove(row); 
            }
        }
        private void toolStripButtonEditRooms_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                RoomEditForm form = new RoomEditForm(int.Parse(row.Cells[0].Value.ToString()), this);
                form.Show();
            }
        }

        private void buttonEditRow_Click(object sender, EventArgs e)
        {
            if (toolStripEditObject.Visible)
            {
                toolStripEditObject.Hide();
            }
            else
            {
                toolStripEditObject.Show();
            }
        }
    }
}