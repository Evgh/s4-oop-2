using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;
using System.Text.RegularExpressions;


namespace s4_oop_2
{
    public class MyBindingSourse : BindingList<Flat>
    {

    }
   
    static class Program
    {

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            try
            {
                Adress.Add("Бел", "Минск", "Центр", "ул. Захарова", "61", 13);
            }
            catch (Adress.AdressValidationException e)
            {
                MessageBox.Show(e.Message);
            }
            try
            {
                Adress.Add("Украина", "Киiв", "Героев", "пр. Славы", "3", 5);

            }
            catch (Adress.AdressValidationException e)
            {
                MessageBox.Show(e.Message);
            }


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            FormBuilder builder = new MainFormBuilder(new MyBindingSourse());
            Form mainForm = FormDirector.Build(builder);
            Application.Run(mainForm);

        }
    }
}
