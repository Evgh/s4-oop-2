using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace s4_oop_2
{
    public interface ICommand
    {
        void Execute();
        void Undo();
        void Redo();
    }

    public class MainMementoCommand : ICommand
    {
        Stack<MainForm.Memento> history = new Stack<MainForm.Memento>();
        //Stack<MainForm.Memento> redo = new Stack<MainForm.Memento>();
        MainForm ordinator;

        public MainMementoCommand(MainForm form)
        {
            ordinator = form;
        }

        public void Execute()
        {
            history.Push(ordinator.GetSnapshot());
            //redo.Clear();
        }

        public void Undo()
        {
            if(history.Count > 0)
            {
                ordinator.SetSnapshot(history.Peek());
                //redo.Push(history.Pop());
            }
        }

        public void Redo()
        {
            //if (redo.Count > 0)
            //{
            //    ordinator.SetSnapshot(redo.Peek());
            //    history.Push(redo.Pop());
            //}
        }
    }


    public class FormSerializationCommand : ICommand
    {
        ISerializer serializer;
        IBindingForm form;

        public FormSerializationCommand(ISerializer serializer, IBindingForm form)
        {
            this.serializer = serializer;
            this.form = form;
        }
        public void Execute()
        {
            serializer.Serialize(form.PrimarySource, form.SaveDialog.FileName);
        }
        public void Undo()
        {
            // не реализовано
        }
        public void Redo()
        {
            // не реализовано
        }
    }

    public class FormDeserializationCommand : ICommand
    {
        ISerializer deserializer;
        IBindingForm form;

        public FormDeserializationCommand(ISerializer deserializer, IBindingForm form)
        {
            this.deserializer = deserializer;
            this.form = form;
        }
        
        public void Execute()
        {
            form.PrimarySource.Clear();
            foreach (IFlat flat in (IBindingListPrototype)deserializer.Deserialize(form.OpenDialog.FileName))
            {
                // Защита на случай, если пул адресов все-таки изменился с момента сохранения и квартиры привязаны к несуществующим адресам
                if (AdressPool.GetAdress(flat.AdressId) == null)
                {
                    flat.AdressId = 0;
                }
                form.PrimarySource.Add(flat);
            }
        }
        public void Undo()
        {
            // не реализовано
        }
        public void Redo()
        {
            // не реализовано
        }
    }
}
