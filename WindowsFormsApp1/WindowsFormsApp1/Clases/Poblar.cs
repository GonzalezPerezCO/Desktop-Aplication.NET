using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Clases
{
    class Poblar
    {
        public void IniciarTodo() {
            PoblarEstudiantes();
            PoblarImplementos();

        }

        private void PoblarImplementos()
        {

            Implemento impBF1 = new Implemento("Balón de futbol", "BF01", "Golty", 10,  1);
            Implemento impBF2 = new Implemento("Balón de futbol", "BF02", "AS", 10, 0);
            Implemento impBF3 = new Implemento("Balón de futbol", "BF03", "Adidas", 5, 0);

            Implemento impBB1 = new Implemento("Balón de voleibol", "BV01", "Golty", 1, 0);
            Implemento impBB2 = new Implemento("Balón de voleibol", "BV02", "Molten", 2, 0);

            Implemento impPF1 = new Implemento("Frisbee", "PF01", "Miyagi", 5, 0);
            Implemento impPF2 = new Implemento("Frisbee", "PF02", "Kyte", 2, 0);
            Implemento impPF3 = new Implemento("Frisbee", "PF03", "Tiger", 10, 4);
            Implemento impPF4 = new Implemento("Frisbee", "PF04", "Olympic", 2, 0);



        }

        private void PoblarEstudiantes()
        {
            Estudiante est1 = new Estudiante("Manuel Sergio","Perez Espitia", 2095112, "Ing de Sistemas", 10, true, new string[] {"Lunes: 08:00","Martes: 15:00","Miercoles: 13:00" }, 0, "Ninguna");
            Estudiante est2 = new Estudiante("Juan Francisco", "Gonzalez Rojas", 2084034, "Ing de Sistemas", 10, true, new string[] { "Lunes: 08:00", "Martes: 15:00", "Miercoles: 13:00" }, 0, "Ninguna");
            Estudiante est3 = new Estudiante("Dulce Maríao", "Rodríguez Muñoz", 2168759, "Ing de Sistemas", 1, true, new string[] { "Lunes: 08:00", "Martes: 15:00", "Viernes: 13:00" }, 0, "Tensión alta");
            Estudiante est4 = new Estudiante("Sara Sofía", "Gómez Ramírez", 2138491, "Ing de Sistemas", 1, true, new string[] { "Lunes: 08:00", "Martes: 15:00", "Viernes: 13:00" }, 0, "Diabético");
            Estudiante est5 = new Estudiante("Luisa Fernanda", "López Jiménez", 2144169, "Ing de Sistemas", 1, true, new string[] { "Lunes: 08:00", "Martes: 15:00", "Miercoles: 13:00" }, 0, "Ninguna");
            Estudiante est6 = new Estudiante("Sara Valentina", "González Torres", 2150980, "Ing de Sistemas", 1, true, new string[] { "Martes: 08:00", "Martes: 15:00", "Viernes: 13:00" }, 0, "Ninguna");
            Estudiante est7 = new Estudiante("María Fernanda", "García González", 2179198, "Ing de Sistemas", 1, true, new string[] { "Martes: 08:00", "Martes: 15:00", "Miercoles: 13:00" }, 0, "Ninguna");
            Estudiante est8 = new Estudiante("Ana Sofía", "Martínez Sánchez", 2184143, "Ing de Sistemas", 1, true, new string[] { "Martes: 08:00", "Martes: 15:00", "Viernes: 13:00" }, 0, "Ninguna");
            Estudiante est9 = new Estudiante("Ana Lucía", "Ramírez Vargas", 2177199, "Ing de Sistemas", 1, true, new string[] { "Martes: 08:00", "Martes: 15:00", "Miercoles: 13:00" }, 0, "Ninguna");
            Estudiante est10 = new Estudiante("María Camila", "Sánchez Moreno", 2130249, "Ing de Sistemas", 1, true, new string[] { "Martes: 08:00", "Martes: 15:00", "Miercoles: 13:00" }, 0, "Ninguna");
            Estudiante est11 = new Estudiante("Juan José", "Hernández Martínez", 2159052, "Ing de Sistemas", 1, true, new string[] { "Miercoles: 08:00", "Martes: 15:00", "Viernes: 13:00" }, 0, "Ninguna");
            Estudiante est12 = new Estudiante("Miguel Angel", "Díaz Rojas", 2118530, "Ing de Sistemas", 10, true, new string[] { "Lunes: 08:00", "Martes: 15:00", "Miercoles: 13:00" }, 0, "Ninguna");
            Estudiante est13 = new Estudiante("Juan Sebastián", "Perez Martínez", 2118187, "Ing de Sistemas", 9, true, new string[] { "Miercoles: 08:00", "Martes: 15:00", "Miercoles: 13:00" }, 0, "Ninguna");
            Estudiante est14 = new Estudiante("Juan David", "Torres Muñoz", 2081829, "Ing de Sistemas", 8, true, new string[] { "Lunes: 08:00", "Martes: 15:00", "Miercoles: 13:00" }, 0, "Ninguna");
            Estudiante est15 = new Estudiante("Samuel David", "Rojas Hernández", 2119863, "Ing de Sistemas", 5, true, new string[] { "Miercoles: 08:00", "Martes: 15:00", "Viernes: 13:00" }, 0, "Ninguna");
            Estudiante est16 = new Estudiante("Juan Pablo", "Vargas Díaz", 2104696, "Ing de Sistemas", 10, true, new string[] { "Lunes: 08:00", "Martes: 15:00", "Miercoles: 13:00" }, 0, "Ninguna");
            Estudiante est17 = new Estudiante("Andrés Felipe", "Moreno Moreno", 2103635, "Ing de Sistemas", 2, true, new string[] { "Lunes: 08:00", "Martes: 15:00", "Viernes: 13:00" }, 0, "Problemas del corazón");
            Estudiante est18 = new Estudiante("Juan Esteban", "Gutiérrez Sánchez", 2149415, "Ing de Sistemas", 2, true, new string[] { "Lunes: 08:00", "Martes: 15:00", "Viernes: 13:00" }, 0, "Ninguna");
            Estudiante est19 = new Estudiante("Juan Diego", "Jiménez  Ramírez", 2116669, "Ing de Sistemas", 6, true, new string[] { "Miercoles: 08:00", "Martes: 15:00", "Miercoles: 13:00" }, 0, "Ninguna");
            Estudiante est20 = new Estudiante("Angel David", "Muñoz Martínez", 2129409, "Ing de Sistemas", 7, true, new string[] { "Martes: 08:00", "Miercoles: 15:00", "Viernes: 13:00" }, 0, "Tensión alta");

        }
    }    
}
