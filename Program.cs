﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text;
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
            //try
            //{
            //    Adress buff = Adress.CreateAdress();
            //    AdressPool.GetPool().Add(buff);
            //}
            //catch (Adress.AdressValidationException e)
            //{
            //    MessageBox.Show(e.Message);
            //}
            //try
            //{
            //    Adress buff = Adress.CreateAdress("Бел", "Минск", "Центр", "ул. Захарова", "61", 13);
            //    AdressPool.GetPool().Add(buff);
            //}
            //catch (Adress.AdressValidationException e)
            //{
            //    MessageBox.Show(e.Message);
            //}
            //try
            //{
            //    Adress buff = Adress.CreateAdress("Украина", "Киiв", "Героев", "пр. Славы", "3", 5);
            //    AdressPool.GetPool().Add(buff);
            //}
            //catch (Adress.AdressValidationException e)
            //{
            //    MessageBox.Show(e.Message);
            //}


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(FormDirector.CreateForm(new MainFormBuilder()));
        }
    }
}
