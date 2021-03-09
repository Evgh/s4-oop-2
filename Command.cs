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
}
