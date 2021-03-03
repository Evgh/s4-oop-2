using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Linq;
using Newtonsoft.Json;

using System.ComponentModel;

namespace s4_oop_2
{
    public interface IBindingForm<T, K>
    {
        BindingList<T> PrimarySource { get; }
        BindingList<K> SecondarySource { get;}
    }


    public interface IFormBuilder<T, K>
    {
        Form CreateForm(object obj = null);
        Form CreateForm(BindingList<T> primary, BindingList<K> secondary, object formArgs);
        BindingList<T> CreatePrimarySource();
        BindingList<K> CreateSecondarySource();
    }

    public class MainFactoryBuilder : IFormBuilder<IFlat, Adress>
    {
        public Form CreateForm(BindingList<IFlat> primary, BindingList<Adress> secondary, object obj = null)
        {
            Form myForm = new MainForm(primary, secondary, obj);
            return myForm;
        }

        public Form CreateForm(object obj = null )
        {
            BindingList<IFlat> primary = CreatePrimarySource();
            BindingList<Adress> secondary = CreateSecondarySource();

            return CreateForm(primary, secondary, obj);
        }

        public BindingList<IFlat> CreatePrimarySource()
        {
            return new FlatSourse();
        }

        public BindingList<Adress> CreateSecondarySource()
        {
            return null;
        }
    }
}
