using System;

namespace Tiempo
{
    [Serializable()]
    public class Alarma
    {
        private Boolean Activa;
        public DateTime Hora { set; get; }

        public void setActiva(Boolean value)
        {
            Activa = value;
        }

        public bool getAlarma()
        {
            return Activa;
        }
    }
}