//Darwin Alexander 2024-1733
using System;
using System.Collections.Generic;

class Contacto
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Telefono { get; set; }
    public string Email { get; set; }
    public string Direccion { get; set; }

    public void Mostrar()
    {
        Console.WriteLine($"{Id}    {Nombre}    {Telefono}    {Email}    {Direccion}");
    }
}

class Agenda
{
    private List<Contacto> contactos = new List<Contacto>();
    private int siguienteId = 1;

    public void AgregarContacto()
    {
        var contacto = new Contacto();
        contacto.Id = siguienteId++;

        Console.Write("Nombre: ");
        contacto.Nombre = Console.ReadLine();

        Console.Write("Teléfono: ");
        contacto.Telefono = Console.ReadLine();

        Console.Write("Email: ");
        contacto.Email = Console.ReadLine();

        Console.Write("Dirección: ");
        contacto.Direccion = Console.ReadLine();

        contactos.Add(contacto);
        Console.WriteLine("Contacto agregado exitosamente.\n");
    }

    public void VerContactos()
    {
        Console.WriteLine("\nID    Nombre    Teléfono    Email    Dirección");
        Console.WriteLine("______________________________________________");
        foreach (var c in contactos)
        {
            c.Mostrar();
        }
        Console.WriteLine();
    }

    public void BuscarContacto()
    {
        Console.Write("Ingrese el ID del contacto a buscar: ");
        int id = Convert.ToInt32(Console.ReadLine());

        var contacto = contactos.Find(c => c.Id == id);
        if (contacto != null)
        {
            contacto.Mostrar();
        }
        else
        {
            Console.WriteLine("Contacto no encontrado.\n");
        }
    }

    public void EditarContacto()
    {
        Console.Write("Ingrese el ID del contacto a editar: ");
        int id = Convert.ToInt32(Console.ReadLine());

        var contacto = contactos.Find(c => c.Id == id);
        if (contacto != null)
        {
            Console.Write($"Nuevo nombre ({contacto.Nombre}): ");
            contacto.Nombre = Console.ReadLine();

            Console.Write($"Nuevo teléfono ({contacto.Telefono}): ");
            contacto.Telefono = Console.ReadLine();

            Console.Write($"Nuevo email ({contacto.Email}): ");
            contacto.Email = Console.ReadLine();

            Console.Write($"Nueva dirección ({contacto.Direccion}): ");
            contacto.Direccion = Console.ReadLine();

            Console.WriteLine("Contacto actualizado.\n");
        }
        else
        {
            Console.WriteLine("Contacto no encontrado.\n");
        }
    }

    public void EliminarContacto()
    {
        Console.Write("Ingrese el ID del contacto a eliminar: ");
        int id = Convert.ToInt32(Console.ReadLine());

        var contacto = contactos.Find(c => c.Id == id);
        if (contacto != null)
        {
            contactos.Remove(contacto);
            Console.WriteLine("Contacto eliminado.\n");
        }
        else
        {
            Console.WriteLine("Contacto no encontrado.\n");
        }
    }
}

class Program
{
    static void Main()
    {
        Agenda agenda = new Agenda();
        bool activo = true;

        while (activo)
        {
            Console.WriteLine("Mi Agenda POO");
            Console.WriteLine("1. Agregar Contacto");
            Console.WriteLine("2. Ver Contactos");
            Console.WriteLine("3. Buscar Contacto");
            Console.WriteLine("4. Editar Contacto");
            Console.WriteLine("5. Eliminar Contacto");
            Console.WriteLine("6. Salir");
            Console.Write("Seleccione una opción: ");

            int opcion = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            switch (opcion)
            {
                case 1:
                    agenda.AgregarContacto();
                    break;
                case 2:
                    agenda.VerContactos();
                    break;
                case 3:
                    agenda.BuscarContacto();
                    break;
                case 4:
                    agenda.EditarContacto();
                    break;
                case 5:
                    agenda.EliminarContacto();
                    break;
                case 6:
                    activo = false;
                    break;
                default:
                    Console.WriteLine("Opción no válida.\n");
                    break;
            }
        }

        Console.WriteLine("¡Hasta luego!");
    }
}
