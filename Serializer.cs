using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace s4_oop_2
{
    public interface ISerializerDecorator
    {
        void Serialize();
        void Deserialize();
    }

    public abstract class Serializer
    {
        protected ISerializerDecorator instance;
    }


    public class JsonSerializer<T> : Serializer, ISerializerDecorator
    {
        public JsonSerializer()
        {
        }

        public JsonSerializer(ISerializerDecorator obj)
        {
            instance = obj;
        }

        public void Serialize(IBindingList source, string path)
        {
            var settings = new JsonSerializerSettings();
            settings.Converters.Add(new Converter());

            using (StreamWriter sw = new StreamWriter(path, false))
            {
                sw.WriteLine(JsonConvert.SerializeObject(source, Newtonsoft.Json.Formatting.Indented, settings));
            }

            instance.Serialize();
        }

        public T Deserialize(string path)
        {
            instance.Deserialize();
        }
    }

    public class SuperSerializer : ISerializerDecorator
    {
        public void Serialize()
        {
            XmlSerializer serializer = new XmlSerializer(_flats.GetType());
            using (FileStream fs = new FileStream("serialize.xml", FileMode.OpenOrCreate))
            {
                serializer.Serialize(fs, _flats);
            }
        }

        public void Dererializer()
        {
            XmlSerializer serializer = new XmlSerializer(_flats.GetType());
            using (FileStream fs = new FileStream("serialize.xml", FileMode.Open))
            {
                _flats = (List<Flat>)serializer.Deserialize(fs);
            }

            InitializeDataGridView1();
        }
        
    }


    class Converter : JsonConverter
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
}
