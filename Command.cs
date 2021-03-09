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
    }

    public class SerializationCommand : ICommand
    {
        ISerializer serializer;
        object source;
        FileDialog path;

        public SerializationCommand(ISerializer serializer, object source, FileDialog path)
        {
            this.serializer = serializer;
            this.source = source;
            this.path = path;
        }
        public void Execute()
        {
            serializer.Serialize(source, path.FileName);
        }
    }

    public class BindingListDeserializationCommand : ICommand
    {
        ISerializer deserializer;
        FileDialog path;
        IBindingListPrototype source;

        public BindingListDeserializationCommand(ISerializer deserializer, IBindingListPrototype source, FileDialog path)
        {
            this.deserializer = deserializer;
            this.source = source;
            this.path = path;
        }

        public void Execute()
        {
            source.Clear();
            foreach (IFlat flat in (IBindingListPrototype)deserializer.Deserialize(path.FileName))
            {
                // Защита на случай, если пул адресов все-таки изменился с момента сохранения и квартиры привязаны к несуществующим адресам
                if (AdressPool.GetAdress(flat.AdressId) == null)
                {
                    flat.AdressId = 0;
                }
                source.Add(flat);
            }
        }
    }
}
