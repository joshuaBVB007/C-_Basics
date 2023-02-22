using System;
using paquete_interfaces;
namespace paquete_De_Clases;


public class Estudiante : IActions {
    private int edad=10;
    private string nombre="";

    public Estudiante(string nom){
        this.nombre=nom;
    }
    public Estudiante(string nom,int edad){
        this.nombre=nom;
        this.edad=edad;
    }

    public void dimeNombre(){
        Console.WriteLine("Mi nombre es: "+this.nombre+" y la edad es: "+this.edad);
    }
    bool IActions.quienEres(){
        return true;
    }
}