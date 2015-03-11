//MARTIN AYON ESCALANTE

using System;
using System.Collections;

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
		public void verAlumnos(){
			Console.WriteLine("Alumnos Registrados\n");
			foreach ( string codigo in tabla.Keys){
				try{
					Console.WriteLine("------------------------------------");
					Object obj= tabla[codigo];
					Alumno a= (Alumno) obj;
					Console.WriteLine(a.getDatos());
					
				}catch(Exception e){
					Console.WriteLine("Hay un Error en este dato");
				}
			}
			Console.WriteLine("------------------------------------");
		}
		
		public void eliminarAlumno(){
			String codigo;
			Console.Write("Codigo del alumno: ");
			codigo=Console.ReadLine();
			if(tabla.ContainsKey(codigo)){
			   	tabla.Remove(codigo);
			   	Console.WriteLine("Se Elminó el alumno con el codigo : "+ codigo);
			}
			   	else Console.WriteLine("NO HAY alumno con codigo "+codigo);
			   	Console.WriteLine("\n------------------------------------");
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
						case 2:programa.verAlumnos();
						break;
						case 3:programa.eliminarAlumno();
						break;
						default:Console.WriteLine("ADIOSINI");
						Console.ReadLine();
						break;
				}
			}while (opcion<4);
		}
	}
}