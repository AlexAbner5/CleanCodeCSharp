using System;
using System.Collections.Generic;

namespace ToDo
{
    internal class Program
    {
        public static List<string> TaskList { get; set; } = new List<string>();

        static void Main(string[] args)
        {
        
            int menuSelected = 0;
            do

            {

                menuSelected = ShowMainMenu();

                switch (menuSelected)

                {

                    case 1:

                        menuSelected = 1;

                        ShowMenuAdd();

                        break;

                    case 2:

                        menuSelected = 2;

                        ShowMenuRemove();

                        break;

                    case 3:

                        menuSelected = 3;

                        ShowMenuTaskList();

                        break;

                    case 4:

                        menuSelected = 4;

                        break;

                    default:

                        Console.WriteLine("porfavor ingresa una opcion valida");

                        break;

                }

            } while (menuSelected != 4);
        }
        /// <summary>
        /// Show the main menu 
        /// </summary>
        /// <returns>Returns option indicated by user</returns>
        public static int ShowMainMenu()
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Ingrese la opción a realizar: ");
            Console.WriteLine("1. Nueva tarea");
            Console.WriteLine("2. Remover tarea");
            Console.WriteLine("3. Tareas pendientes");
            Console.WriteLine("4. Salir");

            // Read line
            string line = Console.ReadLine();
            return Convert.ToInt32(line);
        }

        public static void ShowMenuRemove()
        {
            try
            {
                Console.WriteLine("Ingrese el número de la tarea a remover: ");
                // Show current taks
                ShowMenuTaskList();

                string line = Console.ReadLine();
                // Remove one position
                int indexToRemove = Convert.ToInt32(line) - 1;

                if (indexToRemove <= (TaskList.Count - 1) || indexToRemove >= 0)
                    Console.WriteLine("Por favor ingrese una tarea valida");
                else
                { }
                if (indexToRemove > -1 && TaskList.Count > 0)
                {
                        string task = TaskList[indexToRemove];
                        TaskList.RemoveAt(indexToRemove);
                        Console.WriteLine("Tarea " + task + " eliminada");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error inesperado");
            }
        }

        public static void ShowMenuAdd()
        {
            try
            {
                Console.WriteLine("Ingrese el nombre de la tarea: ");
                string task = Console.ReadLine();
                TaskList.Add(task);
                Console.WriteLine("Tarea registrada");
            }
            catch (Exception)
            {
            }
        }

        public static void ShowMenuTaskList()
        {
            if (TaskList?.Count > 0)
            {
                Console.WriteLine("----------------------------------------");
                var indexTask = 1;
                //  Aqui habia un ciclo for que se cambio por un foreach para recorrer la lista de tareas
                TaskList.ForEach(task => Console.WriteLine($"{indexTask++} . {task}"));

                Console.WriteLine("----------------------------------------");

                Console.WriteLine("No hay tareas por realizar");
            } 
            else
            {
                Console.WriteLine("No hay tareas por realizar");

            }
        }
    }

}


// Se cambio el nombre de la lista de tareas antes TL a TaskList
// Se cambio el nombre de la variable llada "variable" en la linea 13 a menuSelected
// Se cambio el nombre de ShowMenuDos en la linea 23 a ShowMenuRemove
// Se cambio el nombre de ShowMenuTres en la linea 27 a ShowMenuTasList