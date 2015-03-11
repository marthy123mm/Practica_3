
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
		}
	}
}