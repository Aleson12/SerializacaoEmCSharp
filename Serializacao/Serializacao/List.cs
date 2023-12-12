using System;
using System.Collections.Generic;

namespace Serializacao
{
    internal class List
    {
        internal void Add(Empresa empresa)
        {
            throw new NotImplementedException();
        }

        public static implicit operator List(List<Empresa> v)
        {
            throw new NotImplementedException();
        }
    }
}