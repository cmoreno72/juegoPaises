using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriasJuego
{
    public interface Continente
    {
        string nombre { get; }
        public List <string> getPaises { get; }
        public Pais getPais(string nombre);

    }
}