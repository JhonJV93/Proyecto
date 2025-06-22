using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("PROYECTO");

        Agenda agenda = new Agenda(10); // Capacidad para 10 contactos

        // Agregar contactos
        agenda.AgregarContacto(new ContactoPersonal("Doris Vizueta", "0958614559", "Mama"));
        agenda.AgregarContacto(new ContactoProfesional("Jimmy Lirio", "093945689", "Policia"));
        agenda.AgregarContacto(new ContactoProfesional("Hector Veloz", "0969450948", "Sargento"));
        agenda.AgregarContacto(new ContactoPersonal("Luana Velasco", "0989484900", "Hija"));
        agenda.AgregarContacto(new ContactoProfesional("Ariel Baque", "0991234567", "Estudiante UEA"));
        agenda.AgregarContacto(new ContactoProfesional("Luis Acosta", "0998578230", "Capitan"));
        agenda.AgregarContacto(new ContactoPersonal("Morella Aldaz", "0994785321", "Esposa"));
        agenda.AgregarContacto(new ContactoProfesional("Yani Barzola", "0991994457", "Sargento"));
        agenda.AgregarContacto(new ContactoProfesional("Jeidy Castro", "0996700308", "Estudiante UEA"));
        agenda.AgregarContacto(new ContactoPersonal("Evelyn Velasco", "0987678321", "Amiga"));

        // Mostrar contactos sin ordenar
        agenda.MostrarContactos();

        // Ordenar por nombre
        agenda.OrdenarPorNombre();

        Console.WriteLine("\n--- Contactos Ordenados ---");
        agenda.MostrarContactos();

        // Buscar un contacto
        Console.WriteLine("\nIngrese un nombre para buscar:");
        string? entrada = Console.ReadLine(); // puede ser null
        string nombre = entrada ?? "";        // si es null, se reemplaza con ""
        agenda.BuscarContacto(nombre);

        Console.WriteLine("\nPresione cualquier tecla para salir...");
        Console.ReadKey();
    }
}
