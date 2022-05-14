using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class ExtendTime
    {
        public static string DiaSemana(this DateTime dt)
        {
            StringBuilder sb = new StringBuilder(); 
            switch (dt.DayOfWeek)
            {
                case DayOfWeek.Sunday:
                    sb.AppendLine("Buen domingo, hoy se descansa!!");
                    break;
                case DayOfWeek.Monday:
                    sb.AppendLine("Que tengas un hermoso lunes, vamos que empieza la semana!!");
                    break;
                case DayOfWeek.Tuesday:
                    sb.AppendLine("Martes, que tengas un buen dia!!");
                    break;
                case DayOfWeek.Wednesday:
                    sb.AppendLine("Estamos a mitad de semana, miercoles!!");
                    break;
                case DayOfWeek.Thursday:
                    sb.AppendLine("Hoy, jueves falta poco para el finde!!");
                    break;
                case DayOfWeek.Friday:
                    sb.AppendLine("Viernessssss!!");
                    break;
               case DayOfWeek.Saturday:
                    sb.AppendLine("Hoy es sabado, dia de paseos!!");
                    break;
              
            }
            return sb.ToString();
        }
    }
}
