﻿//CLASE ALUMNO
using System;

namespace Practica_3
{

	public class Alumno
	{
		private String nombre;
		private String codigo;
		
		public Alumno(String n, String c)
		{
			nombre=n;
			codigo=c;
		}
		public Alumno(){
			nombre="";
			codigo="";
		}
		
		public void setNomnre(String nombre){
			this.nombre=nombre;
		}
		public String getNombre(){
			return nombre;
		}
		public void setCodigo(String nombre){
			this.nombre=nombre;
		}
		public String getCodigo(){
			return codigo;
		}
		
		public String getDatos(){
			return "nombre: "+nombre+"\n" + "Codigo: "+codigo;
		}
	}
}
