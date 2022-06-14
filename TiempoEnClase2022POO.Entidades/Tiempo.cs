using System;

namespace TiempoEnClase2022POO.Entidades
{
    public class Tiempo
    {
        private int Hora;
        private int Minutos;
        private int Segundos;

        public Tiempo(int hora, int minutos, int segundos)
        {
            Hora = hora;
            Minutos = minutos;
            Segundos = segundos;

        }

        public Tiempo(int hora, int minutos):this(hora, minutos,59)
        {
            
        }

        public Tiempo(int hora):this(hora, 59)
        {
            
        }

        //public string MostrarHora()
        //{
        //    return $"{Hora}:{Minutos}:{Segundos}";
        //}

        public override string ToString()
        {
            return $"{Hora.ToString().PadLeft(2,'0')}:{Minutos.ToString().PadLeft(2, '0')}:{Segundos.ToString().PadLeft(2, '0')}";
        }

        public bool Validar()
        {
            return Hora >= 1 && Hora <= 23 
                             && Minutos >= 1 && Minutos <= 59
                             && Segundos >= 1 && Segundos <= 59;
        }

        public override bool Equals(object obj)
        {
            if (obj==null || !(obj is Tiempo))
            {
                return false;
            }

            return this.Hora == ((Tiempo) obj).Hora &&
                   this.Minutos == ((Tiempo) obj).Minutos &&
                   this.Segundos == ((Tiempo) obj).Segundos;
        }

        public static bool operator ==(Tiempo t1, Tiempo t2)
        {
            return t1.Equals(t2);
        }

        public static bool operator !=(Tiempo t1, Tiempo t2)
        {
            return !(t1 == t2);
        }

        public static Tiempo operator +(Tiempo t1, Tiempo t2)
        {
            var nuevaHora = t1.Hora + t2.Hora;
            var nuevoMinutos = t1.Minutos + t2.Minutos;
            var nuevoSegundos = t1.Segundos + t2.Segundos;

            if (nuevoSegundos>=60)
            {
                nuevoSegundos -= 60;
                nuevoMinutos++;
            }

            if (nuevoMinutos>=60)
            {
                nuevoMinutos -= 60;
                nuevaHora++;
            }

            if (nuevaHora>=24)
            {
                nuevaHora -= 24;

            }
            return new Tiempo(nuevaHora, nuevoMinutos, nuevoSegundos);

        }

        public static implicit operator Tiempo(string s)
        {
            var array = s.Split(':');
            var hora = int.Parse(array[0]);
            var minutos = int.Parse(array[1]);
            var segundos = int.Parse(array[2]);
            return new Tiempo(hora,minutos,segundos);
        }
        public static explicit operator int(Tiempo t)
        {
            return (t.Segundos + (60 * (t.Minutos + t.Hora * 60)));
        }

    }
}
