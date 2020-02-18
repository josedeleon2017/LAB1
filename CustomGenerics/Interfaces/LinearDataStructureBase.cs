using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomGenerics.Structures;

namespace CustomGenerics.Interfaces
{
    public abstract class LinearDataStructureBase<T>
    {
        protected abstract void Insert(T value);
        protected abstract void Delete();
        protected abstract T Get();
    }
}
