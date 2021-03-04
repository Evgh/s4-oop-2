using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace s4_oop_2
{
    public interface IBindingListPrototype : IBindingList
    {
        IBindingListPrototype Clone();
    }
}
