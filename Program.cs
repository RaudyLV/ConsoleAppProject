global using System;
global using System.Collections.Generic;
public class ProgramaPrueba {
     static void Main(String[] args) {
        Tarea tarea= new Tarea();
        int opcion;

        do {
            Console.Clear();
            Console.WriteLine("1. Agregar tarea");
            Console.WriteLine("2. Actualizar tarea");
            Console.WriteLine("3.Ver tareas");
            Console.WriteLine("4. Salir del programa");
            Console.Write("Elija una opcion: ");

            while (!int.TryParse(Console.ReadLine(), out opcion)) {
                Console.Write("Ingrese un numero valido: ");
            }


            switch(opcion){
                case 1: tarea.AgregarTarea();
                break;

                case 2: tarea.ActualizarTarea();
                break;

                case 3: tarea.VerTareas();
                break;

                case 4: Console.WriteLine("Saliste del programa...");
                break;

                default: Console.WriteLine("Ingrese una opcion valida...");
                break;
            }
           
        }while(opcion != 4);

    }

  
}
