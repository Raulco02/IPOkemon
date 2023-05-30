using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPOkemon_Raul_Calzado
{
    public interface InPokemon
    {
        event EventHandler<Ataque> ataqueRealizado;
        event EventHandler<Ataque> ataqueFallado;
        event EventHandler<string> debilitado;
        event EventHandler<object> muerteSubita;
    }
}