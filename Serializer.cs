using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace s4_oop_2
{
    public interface ISerializer
    {
        void Serialize(object source, string path);
        object Deserialize(string path);
    }
    public abstract class Serializer<T>
    {
        protected ISerializer instance;
    }

    public class MyJsonSerializer<T> : Serializer<T>, ISerializer 
    {
        public MyJsonSerializer()
        {
        }

        public MyJsonSerializer(ISerializer obj)
        {
            instance = obj;
        }
        public void Serialize(object source, string path)
        {
            var settings = new JsonSerializerSettings();
            settings.Converters.Add(new IFlatConverter());
            settings.Converters.Add(new IBindingListConverter());

            using (StreamWriter sw = new StreamWriter(path, false))
            {
                sw.WriteLine(JsonConvert.SerializeObject(source, Newtonsoft.Json.Formatting.Indented, settings));
            }

            if (instance != null)
            {
                instance.Serialize(source, path);
            }
        }

        public object Deserialize(string path)
        {
            var settings = new JsonSerializerSettings();
            settings.Converters.Add(new IFlatConverter());
            settings.Converters.Add(new IBindingListConverter());

            using (StreamReader sr = new StreamReader(path))
            {
                return JsonConvert.DeserializeObject<T>(sr.ReadToEnd(), settings);
            }
        }
    }

    public class SerializerLogger<T> : Serializer<T>, ISerializer
    {
        string _logPath;
        public SerializerLogger()
        {
        }
        public SerializerLogger(ISerializer obj, string logPath = "LogFile.txt")
        {
            instance = obj;
            _logPath = logPath;
        }
        public void Serialize(object source, string path)
        {   
            if (instance != null)
            {
                instance.Serialize(source, path);

                using (var fs = new StreamWriter(_logPath, true, System.Text.Encoding.UTF8))
                {
                    fs.Write($"{DateTime.Now}: сериализован объект типа {typeof(T)}\n");
                }
            }
        }

        public object Deserialize (string path)
        { 
            if (instance != null)
            {
                using (StreamWriter fs = new StreamWriter(_logPath, true, System.Text.Encoding.UTF8))
                {
                    fs.Write($"{DateTime.Now}: десериализован объект типа {typeof(T)}\n");
                }
                return (T)instance.Deserialize(path);
            }
            else 
            {
                return default(T);
            }
        }
    }


    public class SerializeNotifyer<T> : Serializer<T>, ISerializer
    {
        public SerializeNotifyer(ISerializer serializer) 
        {
            instance = serializer;
        }

        public void Serialize (object sourse, string path)
        {
            if (instance != null)
            {
                MessageBox.Show($"{DateTime.Now} : сериализован объект типа {typeof(T)}");
                instance.Serialize(sourse, path);
            }
        }

        public object Deserialize(string path)
        {
            if (instance != null)
            {
                MessageBox.Show($"{DateTime.Now} : десериализован объект типа {typeof(T)}");
                return (T)instance.Deserialize(path);
            }
            else
            {
                return default(T);
            }
        }    
    } 


    class IFlatConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return (objectType == typeof(IFlat));
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            serializer.Serialize(writer, value, typeof(SimpleFlat));
        }
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            return serializer.Deserialize(reader, typeof(SimpleFlat)); ;
        }
    }
    class IBindingListConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return (objectType == typeof(IBindingListPrototype));
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            serializer.Serialize(writer, value, typeof(SortableBindingList<IFlat>));
        }
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            return serializer.Deserialize(reader, typeof(SortableBindingList<IFlat>)); ;
        }
    }
}
