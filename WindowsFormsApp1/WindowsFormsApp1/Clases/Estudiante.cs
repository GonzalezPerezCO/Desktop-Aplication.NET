using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Clases
{

    class Estudiante
    {
        public string Name { get; set; }
        public string Lastname { get; set; }
        public int Code { get; set; }
        public string Career { get; set; }
        public int Semester { get; set; }
        public bool Enabled { get; set; }

        public string[] Horario { get; set; }
        public int Fallas { get; set; }
        public string Obervaciones { get; set; }

        public Estudiante(string name, string lastname, int code, string career, int semester, bool enabled, string[] horario, int fallas, string obervaciones)
        {
            Name = name;
            Lastname = lastname;
            Code = code;
            Career = career;
            Semester = semester;
            Enabled = enabled;
            Horario = horario;
            Fallas = fallas;
            Obervaciones = obervaciones;
        }
    }

    
}
