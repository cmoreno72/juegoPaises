using System;
using System.Collections.Generic;

namespace LibreriasJuego
{
    public  interface Jugador
    {
        String nombre { get;  }
        public IList<Partida> HistoricoPartidas { get; }
        public Partida nuevaPartida(Continente continenteElegido);
        

    }
}
