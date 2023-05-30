using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPOkemon_Raul_Calzado
{
    public class Ataque
    {
        public string nombre;
        public int dano;
        public Ataque(string nombre, int dano)
        {
            this.nombre = nombre;
            this.dano = dano;
        }
    }
}