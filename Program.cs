using System;

namespace CRUD_23310191
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MateriaCRUD materiaCRUD = new MateriaCRUD();
            int i = 0;

            do
            {

                Console.WriteLine("1. Create Materia \n2. Read Materias \n3. Update Materia \n4. Delete Materia \n5. Exit \n");
                Console.WriteLine("Ingresa la opcion que desees elegir \n");
                i = Convert.ToInt32(Console.ReadLine());

                switch (i)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Ingresa el nombre de la materia");
                        string name = Console.ReadLine();
                        Console.WriteLine("Ingresa el nombre del prfesor de la materia");
                        string teacher = Console.ReadLine();
                        Materia materiaNueva = new Materia
                        {
                            Nombre = name,
                            Profesor = teacher
                        };
                        materiaCRUD.CreateMateria(materiaNueva);
                        break;
                    case 2:
                        Console.Clear();
                        List<Materia> materias = materiaCRUD.GetMaterias();
                        foreach (Materia materia in materias)
                        {
                            Console.WriteLine($"ID: {materia.ID}, Nombre: {materia.Nombre}, Profesor: {materia.Profesor}");
                        }

                        break;
                    case 3:
                        Console.Clear();
                        List<Materia> materiasUpdate = materiaCRUD.GetMaterias();
                        foreach (Materia materia in materiasUpdate)
                        {
                            Console.WriteLine($"ID: {materia.ID}, Nombre: {materia.Nombre}, Profesor: {materia.Profesor}");
                        }

                        Console.WriteLine("Ingrese el ID de la materia que desea actualizar:");
                        int idActualizar = Convert.ToInt32(Console.ReadLine());

                        Materia materiaSeleccionada = materiaCRUD.GetMateriaById(idActualizar);
                        if (materiaSeleccionada != null)
                        {
                            Console.WriteLine($"Materia seleccionada: Nombre: {materiaSeleccionada.Nombre}, Profesor: {materiaSeleccionada.Profesor}");
                            Console.WriteLine("Ingrese el nuevo nombre de la materia:");
                            string nuevoNombre = Console.ReadLine();
                            Console.WriteLine("Ingrese el nuevo nombre del profesor:");
                            string nuevoProfesor = Console.ReadLine();

                            Materia materiaActualizada = new Materia
                            {
                                ID = materiaSeleccionada.ID,
                                Nombre = nuevoNombre,
                                Profesor = nuevoProfesor
                            };

                            materiaCRUD.UpdateMateria(idActualizar, materiaActualizada);
                            Console.WriteLine("Materia actualizada correctamente.");
                        }
                        else
                        {
                            Console.WriteLine("Materia no encontrada.");
                        }
                        break;

                    case 4:
                        Console.Clear();
                        List<Materia> materiasDelete = materiaCRUD.GetMaterias();
                        foreach (Materia materia in materiasDelete)
                        {
                            Console.WriteLine($"ID: {materia.ID}, Nombre: {materia.Nombre}, Profesor: {materia.Profesor}");
                        }
                        Console.WriteLine("Ingrese el ID de la materia que desea eliminar:");
                        int idEliminar = Convert.ToInt32(Console.ReadLine());
                        materiaCRUD.DeleteMateria(idEliminar);
                        break;
                    case 5:
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;

                }
            } while (i != 5);
        }
    }
}
