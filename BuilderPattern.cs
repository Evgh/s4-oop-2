using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Windows.Forms;
using System.Text;
using System.Threading.Tasks;

namespace s4_oop_2
{
    /// <summary>
    /// Шаблон для продуктов 
    /// </summary>
    public abstract class CustomForm : Form
    {
        public virtual MyBindingSourse Flats { get; protected set; }
        //public virtual MyBindingSourse ListBoxData { get; protected set; }
        public virtual DataGridView MyDataGrid { get; }
        public virtual ListBox MyListBox { get; }
    }

    /// <summary>
    /// "Класс-распорядитель определяет стратегию  сборки: 
    /// собирает данные и определяет порядок вызовов методов Строителя.
    /// </summary>
    public static class FormDirector
    {
        public static CustomForm Build(FormBuilder formBuilder)
        {
            formBuilder.CreateForm();
            formBuilder.InitializeDataGrid();
            formBuilder.InitializeListBox();
            return formBuilder.MyForm;
        }
    }

    /// <summary>
    /// Шаблон для классов-строителей 
    /// </summary>
    public abstract class FormBuilder
    {
        protected MyBindingSourse _sourseDataGrid;
        protected MyBindingSourse _sourseList;
        protected CustomForm _myForm;
        public CustomForm MyForm { get => _myForm; }

        public FormBuilder() : this(new MyBindingSourse()) { }
        public FormBuilder(MyBindingSourse sourse)
        {
            _sourseDataGrid = sourse;
        }

        public abstract void CreateForm();
        public abstract void InitializeDataGrid();
        public abstract void InitializeListBox();

    }
    /// <summary>
    /// Строитель главной формы
    /// </summary>
    public class MainFormBuilder : FormBuilder
    {
        public MainFormBuilder() : base() { }
        public MainFormBuilder(MyBindingSourse sourse) : base(sourse) { }

        public override void CreateForm()
        {
            _myForm = new MainForm(_sourseDataGrid);
        }
        public override void InitializeDataGrid()
        {
            MyBindingSourse myBindingSource = _sourseDataGrid;
            _myForm.MyDataGrid.DataSource = myBindingSource;

            _myForm.MyDataGrid.Columns["AdressId"].Visible = false;
            _myForm.MyDataGrid.Columns["FlatAdress"].Visible = false;
            DataGridViewColumn columnAdressLast = _myForm.MyDataGrid.Columns[_myForm.MyDataGrid.Columns.Count - 1];
            DataGridViewColumn columnAdressFirst = _myForm.MyDataGrid.Columns[0];
            columnAdressLast.AutoSizeMode = columnAdressFirst.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;


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
            _myForm.MyDataGrid.Columns.Add(column);
        }

        public override void InitializeListBox()
        {
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = Adress.adressPool;

            _myForm.MyListBox.DataSource = bindingSource;
            _myForm.MyListBox.DisplayMember = "MyToString";
            _myForm.MyListBox.ValueMember = "FlatNumber";
        }
    }


/*    public class RoomEditFormBuilder : FormBuilder
    {
        public override void CreateForm()
        {
            _myForm = new RoomEditForm();
        }

    }*/
}
