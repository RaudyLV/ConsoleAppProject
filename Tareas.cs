using System;
using System.Linq;
public class Tarea {
    private int Id { get; set; }
    public string? Description { get; set; }
    private bool IsCompleted { get; set; }
    private List<Tarea> Tareas { get; set;} = new List<Tarea>();
    private int Contador { get; set; } = 0;

    public override string ToString()
    {
        return $"Tarea: {Id}, {Description}. Estado: {(IsCompleted ? "Completada" : "Pendiente")}";
    }

      public  void AgregarTarea() {
        Console.Clear();
        Console.Write("Digite la descripcion de la tarea: ");
        string descripcion = Console.ReadLine() ?? string.Empty;

        Tareas.Add(new Tarea{Id = ++Contador, Description = descripcion, IsCompleted = false });

         Console.Write("Pulse enter para continuar...");
            Console.ReadKey();
    }

    public void ActualizarTarea(){
        Console.Clear();
        Console.Write("Digite el ID de la tarea ");
        int id;
        while(!int.TryParse(Console.ReadLine(), out id) ){
            Console.WriteLine("Ingrese un numero valido: ");
        }

        if(!Tareas.Any(t => t.Id == id)){
            Console.WriteLine("Tarea no encontrada!");
        }else{

            Tareas[id-1].IsCompleted = true;
        }
        
         Console.Write("Pulse enter para continuar...");
            Console.ReadKey();
    }

    public void EliminarTarea(){
        Console.Write("Ingrese el id de la tarea a eliminar: ");
        int id;
         while(!int.TryParse(Console.ReadLine(), out id) ){
            Console.WriteLine("Ingrese un numero valido: ");
        }

        if(!Tareas.Any(t => t.Id == id)){
            Console.WriteLine("Tarea no encontrada!");
        }else{

            Tareas.RemoveAt(id - 1); //no es la mejor practica.
        }
    }

    public void VerTareas() {
        Console.Clear();
        foreach(var tarea in Tareas){
            Console.WriteLine( tarea.ToString());
        }
         Console.Write("Pulse enter para continuar...");
            Console.ReadKey();
    }
}