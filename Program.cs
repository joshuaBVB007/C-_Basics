using System;
using System.IO;
/*  en c# no hay import como en javascript aqui se usa namespace,
 si te diriges a el fichero Estudiante veras que yo he definido un namespace llamado Clases
 y por eso reconoce la clase Estudiante aquí. */
using paquete_De_Clases;

namespace HelloWorld{
    class Program{
        static void Main(string[] args){
            new Estudiante("jona");
        }
    }
}