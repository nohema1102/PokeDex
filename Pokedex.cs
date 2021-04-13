using System;

namespace PokeDex
{
    class PokeDex
    {
       string nombre;
       int id;
       string genero;

       public PokeDex(string nombre, int id, string genero)
       {
           this.nombre = nombre;
           this.id = id;
           this.genero = genero;
       } 
    }
}