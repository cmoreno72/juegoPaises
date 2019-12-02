using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriasJuego
{
    public interface  Pregunta
    {
        
         public Partida getPartida { get; }
        public Pais pais { get; }
        public bool proponerRespuesta(string capitalSugerida);
        public int IntentosRestantes { get; }
        public List<string> RespuestasPropuestas { get; }
        public bool acierto { get; }
        }
}
