using System;

namespace Tiempo
{
    [Serializable()]
    public class DiferenciaHoraria
    {
        private String nombre;
        public long Hora;

        public void setNombre(String value)
        {
            nombre = value;
        }

        public String getNombre()
        {
            return nombre;
        }

        public void setHora(long value)
        {
            Hora = value;
        }

        public long getHora()
        {
            return Hora;
        }

    }
}