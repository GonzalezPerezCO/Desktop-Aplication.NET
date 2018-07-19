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
        public string Brand { get; set; }
        public int Cant { get; set; }
        public int Lost { get; set; }
        public int Avalaible { get; set; }

        public Estudiante LoTiene { get; set; }
        public bool Devuelto { get; set; }

        public Implemento(string name, string code, string brand, int cant, int lost)
        {
            Name = name;
            Code = code;
            Brand = brand;
            Cant = cant;
            Lost = lost;
            Avalaible = cant - lost;
            LoTiene = null;
            Devuelto = true;
        }
    }
}
