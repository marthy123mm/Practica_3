
using System;

namespace Practica_3
{
	class Program
	{
		private Hashtable tabla;
		
		public Program(){
			tabla=new Hashtable();	
		}
		public void agregarAlumno(){
			String nombre;
			String codigo;
			Console.Clear();
			Console.Write("Nombre del alumno: ");
			nombre=Console.ReadLine();
			Console.Write("Codigo del alumno: ");
			codigo=Console.ReadLine();
			Alumno a=new Alumno(nombre,codigo);
			tabla.Add(codigo,a);
			Console.Clear();
		}
		public static void Main(string[] args)
		{
			int opcion;
			Program programa=new Program();
			do{
				Console.WriteLine("\tPractica 3 Con HashTable\n");
				Console.WriteLine("\t1)Agregar Alumno\n\t2)Ver Alumnos \n\t3)Eliminar Alumno\n\t4)Salir");
				opcion=int.Parse(Console.ReadLine());
				switch(opcion){
						case 1:programa.agregarAlumno();
						break;
						case 2:
						break;
						case 3:
						break;
				}
			}while (opcion<4);
		}
	}
}