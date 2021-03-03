using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Linq;
using Newtonsoft.Json;

using System.Collections;
using System.ComponentModel;

namespace s4_oop_2
{
    public interface IBindingForm
    {
        IBindingList PrimarySource { get; }
        IBindingList SecondarySource { get; }

        void InitializePrimarySource(IBindingList source);
        void InitializeSecondarySource(IBindingList source);
        Form ToForm();
    }

    public static class FormDirector
    {
        public static Form CreateForm(IFormBuilder builder)
        {
            builder.InitializePrimarySource();
            builder.InitializeSecondarySource();
            return builder.GetForm;
        }
    }

    public interface IFormBuilder
    {
        Form GetForm { get; }
        void InitializePrimarySource();
        void InitializeSecondarySource();
    }

    public class MainFormBuilder : IFormBuilder
    {
        IBindingForm currentForm;
        public Form GetForm { get => currentForm.ToForm(); }

        public MainFormBuilder()
        {
            currentForm = new MainForm();
        }

        public void InitializePrimarySource()
        {
            currentForm.InitializePrimarySource(new SortableBindingList<IFlat>() { });
        }

        public void InitializeSecondarySource()
        {
            currentForm.InitializeSecondarySource(Adress.adressPool);
        }
    }
}
