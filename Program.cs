﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;
using System.Text.RegularExpressions;


namespace s4_oop_2
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Func<object, bool> test = delegate (object value)
            //    {
            //        if (value != null)
            //        {
            //            int buff = int.Parse(value.ToString());
            //            return buff != 413;
            //        }
            //        return false;
            //    };

            //MessageBox.Show( test(413).ToString() );

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

            Application.Run(new Form1(new List<Flat> { new Flat() }));
        }
    }
}
