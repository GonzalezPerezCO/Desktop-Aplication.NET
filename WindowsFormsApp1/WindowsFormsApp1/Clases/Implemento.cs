using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Clases
{
    class Implemento
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public int Cant { get; set; }
        public int Lost { get; set; }
        public int Avalaible { get; set; }

        public Estudiante LoTiene { get; set; }
        public bool Devuelto { get; set; }

        public Implemento(string name, string code, int cant, int lost, int avalaible)
        {
            Name = name;
            Code = code;
            Cant = cant;
            Lost = lost;
            Avalaible = avalaible;
            LoTiene = null;
            Devuelto = true;
        }
    }
}
