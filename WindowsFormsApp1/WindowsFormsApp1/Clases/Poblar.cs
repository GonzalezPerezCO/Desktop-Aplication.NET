﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Clases
{
    class Poblar
    {

        private Estudiante est1 { get; set; }
        private Estudiante est2 { get; set; }
        private Estudiante est3 { get; set; }
        private Estudiante est4 { get; set; }
        private Estudiante est5 { get; set; }
        private Estudiante est6 { get; set; }
        private Estudiante est7 { get; set; }
        private Estudiante est8 { get; set; }
        private Estudiante est9 { get; set; }
        private Estudiante est10 { get; set; }
        private Estudiante est11 { get; set; }
        private Estudiante est12 { get; set; }
        private Estudiante est13 { get; set; }
        private Estudiante est14 { get; set; }
        private Estudiante est15 { get; set; }
        private Estudiante est16 { get; set; }
        private Estudiante est17 { get; set; }
        private Estudiante est18 { get; set; }
        private Estudiante est19 { get; set; }
        private Estudiante est20 { get; set; }


        Implemento impBF1 { get; set; }
        Implemento impBF2 { get; set; }
        Implemento impBF3 { get; set; }

        Implemento impBB1 { get; set; }
        Implemento impBB2 { get; set; }

        Implemento impPF1 { get; set; }
        Implemento impPF2 { get; set; }
        Implemento impPF3 { get; set; }
        Implemento impPF4 { get; set; }

        public void IniciarTodo() {
            PoblarEstudiantes();
            PoblarImplementos();
            
        }

        public Estudiante BuscarEstdudiante(int code)
        {
            IniciarTodo();

            Estudiante[] array = TodosEstudiantes();
            Estudiante res = null;

            if (array==null) { MessageBox.Show("array null"); }
            if (array.Length == 0) { MessageBox.Show("array null"); }

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Code.Equals(code)) {
                    res = array[i];
                }
            }

            return res;
        }

            public Estudiante[] TodosEstudiantes()
        {
            Estudiante[] array = new Estudiante[21];

            array[0] = est20;
            array[1] = est1;
            array[2] = est2;
            array[3] = est3;
            array[4] = est4;
            array[5] = est5;
            array[6] = est6;
            array[7] = est7;
            array[8] = est8;
            array[9] = est9;
            array[10] = est10;
            array[11] = est11;
            array[12] = est12;
            array[13] = est13;
            array[14] = est14;
            array[15] = est15;
            array[16] = est16;
            array[17] = est17;
            array[18] = est18;
            array[19] = est19;
            array[20] = est20;

            return array;
        }

        public Implemento[] TodosImplementos()
        {
            Implemento[] array = new Implemento[10];

            array[1] = impBF1;
            array[2] = impBF2;
            array[3] = impBF3;

            array[4] = impBB1;
            array[5] = impBB2;

            array[6] = impPF1;
            array[7] = impPF2;
            array[8] = impPF3;
            array[9] = impPF4;

            return array;
        }

        public void PoblarImplementos()
        {

            impBF1 = new Implemento("Balón de futbol", "BF01", "Golty", 10,  1);
            impBF2 = new Implemento("Balón de futbol", "BF02", "AS", 10, 0);
            impBF3 = new Implemento("Balón de futbol", "BF03", "Adidas", 5, 0);

            impBB1 = new Implemento("Balón de voleibol", "BV01", "Golty", 1, 0);
            impBB2 = new Implemento("Balón de voleibol", "BV02", "Molten", 2, 0);

            impPF1 = new Implemento("Frisbee", "PF01", "Miyagi", 5, 0);
            impPF2 = new Implemento("Frisbee", "PF02", "Kyte", 2, 0);
            impPF3 = new Implemento("Frisbee", "PF03", "Tiger", 10, 4);
            impPF4 = new Implemento("Frisbee", "PF04", "Olympic", 2, 0);
        }

        public void PoblarEstudiantes()
        {
            est1 = new Estudiante("Manuel Sergio","Perez Espitia", 2095112, "Ing de Sistemas", 10, true, new string[] {"Lunes: 08:00","Martes: 15:00","Miercoles: 13:00" }, 0, "Ninguna");
            est2 = new Estudiante("Juan Francisco", "Gonzalez Rojas", 2084034, "Ing de Sistemas", 10, true, new string[] { "Lunes: 08:00", "Martes: 15:00", "Miercoles: 13:00" }, 0, "Ninguna");
            est3 = new Estudiante("Dulce María", "Rodríguez Muñoz", 2168759, "Ing de Sistemas", 1, true, new string[] { "Lunes: 08:00", "Martes: 15:00", "Viernes: 13:00" }, 2, "Tensión alta");
            est4 = new Estudiante("Sara Sofía", "Gómez Ramírez", 2138491, "Ing de Sistemas", 1, true, new string[] { "Lunes: 08:00", "Martes: 15:00", "Viernes: 13:00" }, 0, "Diabético");
            est5 = new Estudiante("Luisa Fernanda", "López Jiménez", 2144169, "Ing de Sistemas", 1, true, new string[] { "Lunes: 08:00", "Martes: 15:00", "Miercoles: 13:00" }, 0, "Ninguna");
            est6 = new Estudiante("Sara Valentina", "González Torres", 2150980, "Ing de Sistemas", 1, true, new string[] { "Martes: 08:00", "Martes: 15:00", "Viernes: 13:00" }, 0, "Ninguna");
            est7 = new Estudiante("María Fernanda", "García González", 2179198, "Ing de Sistemas", 1, true, new string[] { "Martes: 08:00", "Martes: 15:00", "Miercoles: 13:00" }, 0, "Ninguna");
            est8 = new Estudiante("Ana Sofía", "Martínez Sánchez", 2184143, "Ing de Sistemas", 1, true, new string[] { "Martes: 08:00", "Martes: 15:00", "Viernes: 13:00" }, 0, "Ninguna");
            est9 = new Estudiante("Ana Lucía", "Ramírez Vargas", 2177199, "Ing de Sistemas", 1, true, new string[] { "Martes: 08:00", "Martes: 15:00", "Miercoles: 13:00" }, 0, "Ninguna");
            est10 = new Estudiante("María Camila", "Sánchez Moreno", 2130249, "Ing de Sistemas", 1, true, new string[] { "Martes: 08:00", "Martes: 15:00", "Miercoles: 13:00" }, 0, "Ninguna");
            est11 = new Estudiante("Juan José", "Hernández Martínez", 2159052, "Ing de Sistemas", 1, true, new string[] { "Miercoles: 08:00", "Martes: 15:00", "Viernes: 13:00" }, 0, "Ninguna");
            est12 = new Estudiante("Miguel Angel", "Díaz Rojas", 2118530, "Ing de Sistemas", 10, true, new string[] { "Lunes: 08:00", "Martes: 15:00", "Miercoles: 13:00" }, 0, "Ninguna");
            est13 = new Estudiante("Juan Sebastián", "Perez Martínez", 2118187, "Ing de Sistemas", 9, true, new string[] { "Miercoles: 08:00", "Martes: 15:00", "Miercoles: 13:00" }, 0, "Ninguna");
            est14 = new Estudiante("Juan David", "Torres Muñoz", 2081829, "Ing de Sistemas", 8, true, new string[] { "Lunes: 08:00", "Martes: 15:00", "Miercoles: 13:00" }, 0, "Ninguna");
            est15 = new Estudiante("Samuel David", "Rojas Hernández", 2119863, "Ing de Sistemas", 5, true, new string[] { "Miercoles: 08:00", "Martes: 15:00", "Viernes: 13:00" }, 0, "Ninguna");
            est16 = new Estudiante("Juan Pablo", "Vargas Díaz", 2104696, "Ing de Sistemas", 10, true, new string[] { "Lunes: 08:00", "Martes: 15:00", "Miercoles: 13:00" }, 0, "Ninguna");
            est17 = new Estudiante("Andrés Felipe", "Moreno Moreno", 2103635, "Ing de Sistemas", 2, true, new string[] { "Lunes: 08:00", "Martes: 15:00", "Viernes: 13:00" }, 0, "Problemas del corazón");
            est18 = new Estudiante("Juan Esteban", "Gutiérrez Sánchez", 2149415, "Ing de Sistemas", 2, true, new string[] { "Lunes: 08:00", "Martes: 15:00", "Viernes: 13:00" }, 0, "Ninguna");
            est19 = new Estudiante("Juan Diego", "Jiménez  Ramírez", 2116669, "Ing de Sistemas", 6, true, new string[] { "Miercoles: 08:00", "Martes: 15:00", "Miercoles: 13:00" }, 0, "Ninguna");
            est20 = new Estudiante("Angel David", "Muñoz Martínez", 2129409, "Ing de Sistemas", 7, true, new string[] { "Martes: 08:00", "Miercoles: 15:00", "Viernes: 13:00" }, 0, "Tensión alta");

        }

       
    }    
}
