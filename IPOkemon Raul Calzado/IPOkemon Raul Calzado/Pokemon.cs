using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPOkemon_Raul_Calzado
{
    public class Pokemon
    {
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public double altura { get; set; }
        public double peso { get; set; }
        public string tipo { get; set; }
        public string imagen_pokemon { get; set; }

        public Pokemon(string nombre, string descripcion, double altura, double peso, string tipo, string imagen_pokemon) { 
            this.nombre= nombre;
            this.descripcion= descripcion;
            this.altura = altura;
            this.peso = peso;
            this.tipo = tipo;
            this.imagen_pokemon= imagen_pokemon;
        }
    }
}
