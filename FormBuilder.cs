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
            builder.InitializeCommands();
            return builder.GetForm;
        }
    }

    public interface IBindingForm
    {
        IBindingListPrototype PrimarySource { get; }
        IBindingListPrototype SecondarySource { get; }

        SaveFileDialog SaveDialog { get; }
        OpenFileDialog OpenDialog { get; }

        void InitializePrimarySource(IBindingListPrototype source);
        void InitializeSecondarySource(IBindingListPrototype source);
        void InitializeCommands(List<ICommand> commands);
        Form ToForm();
    }

    public interface IFormBuilder
    {
        Form GetForm { get; }
        void InitializePrimarySource();
        void InitializeSecondarySource();
        void InitializeCommands();
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
            currentForm.InitializeSecondarySource(AdressPool.GetPool()) ;
        }

        public void InitializeCommands()
        {
            var serializer = new MyJsonSerializer<IBindingListPrototype>();
            var loggingSerializer = new SerializerLogger<IBindingListPrototype>(serializer);
            var superSerializer = new SerializeNotifyer<IBindingListPrototype>(loggingSerializer);

            var serializationCommand = new SerializationCommand(superSerializer, currentForm.PrimarySource, currentForm.SaveDialog);


            var deserializer = new MyJsonSerializer<IBindingListPrototype>();
            var loggingDeserializer = new SerializerLogger<IBindingListPrototype>(deserializer);

            var deserializationCommand = new BindingListDeserializationCommand(loggingDeserializer, currentForm.PrimarySource, currentForm.OpenDialog);

            currentForm.InitializeCommands(new List<ICommand> { serializationCommand, deserializationCommand });
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
            currentForm.InitializePrimarySource(AdressPool.GetPool());
        }

        public void InitializeSecondarySource()
        {
            currentForm.InitializeSecondarySource(null);
        }

        public void InitializeCommands()
        {
            // не реализовано
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

        public void InitializeCommands()
        {
            // не реализовано
        }
    }

    public class SearchFormBuilder : IFormBuilder
    {
        IBindingForm currentForm; 
        IBindingForm _parent; // чтобы инициализировать источники данных
        public Form GetForm => currentForm.ToForm();

        public SearchFormBuilder(SearchFormArgs sfa, MainForm parent)
        {
            _parent = parent;
            currentForm = new SearchForm(sfa); 
        }

        public void InitializePrimarySource()
        {
            currentForm.InitializePrimarySource(_parent.PrimarySource.Clone());
        }

        public void InitializeSecondarySource()
        {
            currentForm.InitializeSecondarySource(_parent.PrimarySource);
        }

        public void InitializeCommands()
        {
            var serializer = new MyJsonSerializer<IBindingListPrototype>();
            var notifySerializer = new SerializeNotifyer<IBindingListPrototype>(serializer);
            var serializationCommand = new SerializationCommand(notifySerializer, currentForm.PrimarySource, currentForm.SaveDialog);

            currentForm.InitializeCommands(new List<ICommand> { serializationCommand });
        }
    }
}
