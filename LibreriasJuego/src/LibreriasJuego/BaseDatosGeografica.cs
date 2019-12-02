﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriasJuego.src.LibreriasJuego
{
    public interface BaseDatosGeografica

    {
        public Pais getPais(string nombrePais);
        public Continente getContinente(string nombreContinente);

        public List<Continente> getContinentes();
    }
}
