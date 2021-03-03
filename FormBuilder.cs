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
    public static class FormDirector
    {
        public static Form CreateForm(IFormBuilder builder)
        {
            builder.InitializePrimarySource();
            builder.InitializeSecondarySource();
            return builder.GetForm;
        }
    }

    public interface IBindingForm
    {
        IBindingList PrimarySource { get; }
        IBindingList SecondarySource { get; }

        void InitializePrimarySource(IBindingList source);
        void InitializeSecondarySource(IBindingList source);
        Form ToForm();
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

    public class AdressEditFormBuilder : IFormBuilder
    {
        IBindingForm currentForm;
        public Form GetForm => currentForm.ToForm();

        public AdressEditFormBuilder()
        {
            currentForm = new AdressEditForm();
        }
        public void InitializePrimarySource()
        {
            currentForm.InitializePrimarySource(Adress.adressPool);
        }

        public void InitializeSecondarySource()
        {
            currentForm.InitializeSecondarySource(null);
        }
    }

    public class RoomEditFormBuilder : IFormBuilder
    {
        IBindingForm currentForm;
        IFlat curentFlat;
        public Form GetForm => currentForm.ToForm();

        public RoomEditFormBuilder(IFlat flat)
        {
            currentForm = new RoomEditForm(flat);
            curentFlat = flat;

        }
        public void InitializePrimarySource()
        {
            currentForm.InitializePrimarySource(null);
        }

        public void InitializeSecondarySource()
        {
            currentForm.InitializeSecondarySource(curentFlat.Rooms);
        }
    }

    public class SearchFormBuilder : IFormBuilder
    {
        IBindingForm currentForm;
        IBindingForm _parent;
        SearchFormArgs args;
        public Form GetForm => currentForm.ToForm();

        public SearchFormBuilder(SearchFormArgs sfa, MainForm parent)
        {
            _parent = parent;
            args = sfa;
            currentForm = new SearchForm(sfa, parent); 
        }

        public void InitializePrimarySource()
        {
            SortableBindingList<IFlat> flats = new SortableBindingList<IFlat> { };
            foreach(IFlat element in _parent.PrimarySource)
            {
                flats.Add(element);
            }
            currentForm.InitializePrimarySource(flats);
        }

        public void InitializeSecondarySource()
        {
            currentForm.InitializeSecondarySource(null);
        }
    }
}
