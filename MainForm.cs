﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Linq;
using Newtonsoft.Json;


namespace s4_oop_2
{
    public partial class MainForm : Form, IBindingForm
    {
        public MainForm()
        {
            InitializeComponent();
            InitializeShortcutKeys();
            InitializeTimer();
        }

        IBindingListPrototype primary;
        IBindingListPrototype secondary;

        ICommand serializeCommand;
        ICommand deserializeCommand;
        ICommand mementoCommand;
        
        public IBindingListPrototype PrimarySource => primary;
        public IBindingListPrototype SecondarySource => secondary;

        public SaveFileDialog SaveDialog => saveFileDialog1;
        public OpenFileDialog OpenDialog => openFileDialog1;
        public Form ToForm() => this;

        /// <summary>
        /// Для передачи данных из полей ввода в конструктор Flat
        /// </summary>
        FlatArgs MyFlatArgs => new FlatArgs
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

        ////////////////////////////////////////////////////////////////////// методы, инициализирующие определенные компоненты
        public void InitializePrimarySource(IBindingListPrototype source)
        {
            primary = source;
            dataGridView1.DataSource = PrimarySource;
            AddComboBoxColumn();

            if (PrimarySource != null)
            {
                dataGridView1.Columns["AdressId"].Visible = false;
                dataGridView1.Columns["FlatAdress"].Visible = false;
                dataGridView1.Columns["Price"].Visible = false;
                DataGridViewColumn columnAdressLast = dataGridView1.Columns[dataGridView1.Columns.Count - 1];
                DataGridViewColumn columnAdressFirst = dataGridView1.Columns[0];
                columnAdressLast.AutoSizeMode = columnAdressFirst.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }
        }

        public void InitializeSecondarySource(IBindingListPrototype source)
        {
            secondary = source;
            listBoxAdress.DataSource = SecondarySource;
            listBoxAdress.DisplayMember = "MyToString";
            listBoxAdress.ValueMember = "FlatNumber";
        }

        public void InitializeCommands(List<ICommand> commands)
        {
            serializeCommand = commands[0];
            deserializeCommand = commands[1];
            mementoCommand = commands[2];
        } 
        /// <summary>
        /// Метод добавляет колонку "Адрес", которую можно редактировать адреса через выпадающий список Combobox 
        /// </summary>
        private void AddComboBoxColumn()
        {
            DataGridViewComboBoxColumn column = new DataGridViewComboBoxColumn();
            column.HeaderText = "Adress";
            column.Width = 300;
            
            //data sourse
            column.DataSource = AdressPool.GetPool();
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
            UndoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Z;
            //RedoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Y;
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

        /// <summary>
        /// Добавление объекта в список квартир
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                    fb = new RandomRoomsFlatBuilder(MyFlatArgs);
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
                    // сначала сохраняем состояние
                    MakeSnapshot(this, new EventArgs());

                    PrimarySource.Add(flat);
                    maskedTextBoxArea.BackColor = maskedTextBoxOwner.BackColor = System.Drawing.SystemColors.Window;

                    // открываем редактор комнат
                    IFormBuilder builder = new RoomEditFormBuilder(flat);
                    Form roomEditor = FormDirector.CreateForm(builder);
                    roomEditor.Show();
                }
            }
            catch (System.FormatException ex)
            {
                // если в поле ввода площади ничего не введено 
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
            Form searchForm = FormDirector.CreateForm(new AdressEditFormBuilder());
            searchForm.Show();
        }

        ////////////////////////////////////////////////// пункт меню "Файл"

        // Сериализация
        private void saveJSONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Java Script Object Notation(*.json)|*.json|All files|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            serializeCommand.Execute();
        }

        private void deserializejSONToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MakeSnapshot(this, new EventArgs());

            openFileDialog1.Filter = "Java Script Object Notation(*.json)|*.json";
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            deserializeCommand.Execute(); 
        }


        // Узнать стоимость квартиры
        private void GetPriceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "";
            if (dataGridView1.SelectedRows.Count == 1)
            {
                IFlat selectedFlat = dataGridView1.SelectedRows[0].DataBoundItem as IFlat;
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
            MakeSnapshot(this, new EventArgs());
            PrimarySource.Clear();
        }

        ////////////////////////////////////////////////// меню "Поиск"

        private void ShowSearchForm(SearchFormArgs args)
        {
            IFormBuilder builder = new SearchFormBuilder(args, this);
            Form searchForm = FormDirector.CreateForm(builder);
            searchForm.Show();
        }

        private void seachRoomAmountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowSearchForm(new SearchFormArgs() { type = true });
        }
        private void searchYearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowSearchForm(new SearchFormArgs() { year = true });
        }

        private void searchDistrictToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowSearchForm(new SearchFormArgs() { district = true });
        }

        private void searchCityStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowSearchForm(new SearchFormArgs() { city = true });
        }

        private void searchManualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowSearchForm(new SearchFormArgs());
        }

        ////////////////////////////////////////////////// О программе 
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа 'Квартиры' v.2.0 (с) Касперович Е.Н.");
        }

        ///////////////////////////////////////////////// Сортировка
        private void sortAreaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MakeSnapshot(this, new EventArgs());
            DataGridViewColumn column = dataGridView1.Columns["Area"];
            dataGridView1.Sort(column, ListSortDirection.Ascending);
        }

        private void sortRoomAmountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MakeSnapshot(this, new EventArgs());
            DataGridViewColumn column = dataGridView1.Columns["RoomAmount"];
            dataGridView1.Sort(column, ListSortDirection.Ascending);
        }

        private void sortPriceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MakeSnapshot(this, new EventArgs());
            DataGridViewColumn column = dataGridView1.Columns["Price"];
            dataGridView1.Sort(column, ListSortDirection.Ascending);
        }

        //private class PriceComparer : IComparer
        //{
        //    private static int sortOrderModifier = 1;

        //    public PriceComparer(SortOrder sortOrder)
        //    {
        //        if (sortOrder == SortOrder.Descending)
        //        {
        //            sortOrderModifier = -1;
        //        }
        //        else if (sortOrder == SortOrder.Ascending)
        //        {
        //            sortOrderModifier = 1;
        //        }
        //    }
        //    public int Compare(object x, object y)
        //    {
        //        DataGridViewRow DataGridViewRow1 = (DataGridViewRow)x;
        //        DataGridViewRow DataGridViewRow2 = (DataGridViewRow)y;

        //        IFlat firstFlat = DataGridViewRow1.DataBoundItem as IFlat;
        //        IFlat secondFlat = DataGridViewRow2.DataBoundItem as IFlat;

        //        // Sort based on the Price.
        //        int CompareResult = (int)firstFlat.GetPrice() - (int)secondFlat.GetPrice();

        //        return CompareResult * sortOrderModifier;
        //    }
        //}

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButtonDeleteRow_Click(object sender, EventArgs e)
        {
            MakeSnapshot(this, new EventArgs());
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.Remove(row); 
            }
        }
        private void toolStripButtonEditRooms_Click(object sender, EventArgs e)
        {
            MakeSnapshot(this, new EventArgs());
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                IFormBuilder builder = new RoomEditFormBuilder(row.DataBoundItem as IFlat);
                Form roomEditor = FormDirector.CreateForm(builder);
                roomEditor.Show();
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                toolStripEditObject.Hide();
            }
            else
            {
                toolStripEditObject.Show();
            }
        }

        // для паттерна Memento
        private void MakeSnapshot(object sender, EventArgs e)
        {
            mementoCommand.Execute();
        }
        private void Undo(object sender, EventArgs e)
        {
            mementoCommand.Undo();
        }
        
        public Memento GetSnapshot()
        {
            return new Memento(this);
        }
        public void SetSnapshot(Memento snapshot)
        {
            primary = snapshot.buffer;
            dataGridView1.DataSource = primary;
        }

        public class Memento
        {
            public IBindingListPrototype buffer;
            public Memento(MainForm form)
            {
                //buffer = new SortableBindingList<IFlat> { new SimpleFlat(new FlatArgs() { adress = AdressPool.GetAdress(0)})};

                buffer = form.PrimarySource.Clone();
            }
        }
    }
}