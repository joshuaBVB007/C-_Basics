using System;
using System.IO;
namespace HelloWorld
{
    class Program{
        static void Main(string[] args){
            //Write into a file
            try{
                 File.WriteAllText("file_practice.txt","Hola mundo");   
            }
            catch (Exception e){ 
                Console.WriteLine(e);
            }
            /* created some objects to confirm they work perfectly 
            here,we have a polimorphism(a pointer from Father class inherits to child class)
            */
            Vehicle car=new Car(4,"Rayo");
            Vehicle veh=new Vehicle();
            car.Run();
            veh.Run();
        }
    }
    // A example of Enums
    enum Names{
        Jonathan,
        Josael,
        Ascencio,
        Calderón
    }

    //Vehicle inherits this class(Car)
    class Car : Vehicle{
        public int ruedas;
        public string nombre;
        public Car(int ruedas,string nombre){
                this.ruedas = ruedas;
                this.nombre = nombre;
        }
        public override void Run(){
                Console.WriteLine("soy coche");
        }
    }

    class Vehicle{
        public string modelName="Mustang";
        public virtual void Run(){
                Console.WriteLine("soy vehiculo");
        }
    }
}


// int numero=5;
// double frac_numero=5.6;
// bool cierto=true;
// char caracter='D';
// string frase="El numero es: ";