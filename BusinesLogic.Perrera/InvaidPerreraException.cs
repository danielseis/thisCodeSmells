using System;
using System.Collections.Generic;
using System.Text;

namespace DogHouse.Domain
{
    [Serializable]
    class InvaidPerreraException : Exception
    {
        public InvaidPerreraException() { }

        public InvaidPerreraException(string texto) : base(texto) {

        }

    }
}
