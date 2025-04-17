using System;

public class Tarea {
    public int Id { get; set; }
    public string? Description { get; set; }
    public bool IsCompleted { get; set; }

    public override string ToString()
    {
        return $"Tarea: {Id}, {Description}. Estado: {(IsCompleted ? "Completada" : "Pendiente")}";
    }
}