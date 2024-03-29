﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Example1_FilesSystem_Comosite;

namespace Composite
{
    internal class Example1_FilesSystem_Comnposite
    {
        public void Run()
        {
            Componente root = new Directorio("raiz");

            Componente archivo1 = new Archivo("archivo1.txt",10);
            Componente archivo2 = new Archivo("archivo2.txt", 30);
            Componente archivo3 = new Archivo("archivo3.txt", 120);
            Componente archivo4 = new Archivo("archivo4.txt", 800);
            Componente archivo5 = new Archivo("archivo5.txt", 340);


            Componente dir1 = new Directorio("dir1");
            Componente dir2 = new Directorio("dir2");
            Componente dir3 = new Directorio("dir3");


            dir1.AgregarHijo(archivo1);
            dir2.AgregarHijo(archivo2);
            dir3.AgregarHijo(archivo3);
            dir3.AgregarHijo(archivo4);
            dir1.AgregarHijo(dir3);


            root.AgregarHijo(dir1);
            root.AgregarHijo(dir2);
            root.AgregarHijo(archivo5);

            Console.WriteLine($"El tamaño deñ archivo {root.Nombre} es {root.ObtenerTamaño}");
            Console.WriteLine($"El tamaño deñ archivo {dir1.Nombre} es {dir1.ObtenerTamaño}");
            Console.WriteLine($"El tamaño deñ archivo {dir2.Nombre} es {dir2.ObtenerTamaño}");
            Console.WriteLine($"El tamaño deñ archivo {dir3.Nombre} es {dir3.ObtenerTamaño}");

            Console.ReadKey();

        }
    }
}
