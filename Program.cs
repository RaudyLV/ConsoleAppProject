global using System;
global using System.Collections.Generic;
public class ProgramaPrueba {
   static List<Tarea> tareas= new List<Tarea>();
    static int contador = 0;
     static void Main(String[] args) {
        

        int opcion;

        do {
            Console.Clear();
            Console.WriteLine("1. Agregar tarea");
            Console.WriteLine("2.Ver tareas");
            Console.WriteLine("3. Salir del programa");
            Console.Write("Elija una opcion: ");

            while (!int.TryParse(Console.ReadLine(), out opcion)) {
                Console.Write("Ingrese un numero valido: ");
            }


            switch(opcion){
                case 1: AgregarTarea();
                break;

                case 2: VerTareas();
                break;

                case 3: Console.WriteLine("Saliste del programa...");
                break;

                default: Console.WriteLine("Ingrese una opcion valida...");
                break;
            }
           
        }while(opcion != 3);

    }

    public static void AgregarTarea() {
        Console.Clear();
        Console.WriteLine("Digite la descripcion de la tarea: ");
        string descripcion = Console.ReadLine() ?? string.Empty;

        tareas.Add(new Tarea{Id = ++contador, Description = descripcion, IsCompleted = false });

         Console.Write("Pulse enter para continuar");
            Console.ReadKey();
    }

    public static void VerTareas() {
        Console.Clear();
        foreach(var tarea in tareas){
            Console.WriteLine( tarea.ToString());
        }
         Console.Write("Pulse enter para continuar");
            Console.ReadKey();
    }
}
