/*
 * Creado por SharpDevelop.
 * Usuario: usuario
 * Fecha: 4/17/2026
 * Hora: 2:16 PM
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.IO;

namespace Persistencia01
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("seccion b");
			
			////creando directorio
			/// 
			string rutaRaiz = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"DatosIUJO");
			string rutaReportes = Path.Combine(rutaRaiz, "Reportes");
			Console.WriteLine(rutaRaiz);
			
			Console.WriteLine(rutaReportes);
			
			if(!Directory.Exists(rutaReportes)){
			   	///crear el directortio reportes 
				Directory.CreateDirectory(rutaReportes);
				Console.WriteLine("directorio creado correctamente");
			   }
			//// 
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}