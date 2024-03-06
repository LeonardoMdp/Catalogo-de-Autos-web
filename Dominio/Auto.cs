using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dominio
{
    class Program
    {
        static void Main(string[] args)
        {
            autoNegocio negocio = new autoNegocio();
            List<Auto> autos = negocio.Listar();

            foreach (var auto in autos)
            {
                Console.WriteLine($"ID: {auto.id}, Modelo: {auto.Modelo}, Descripción: {auto.Descripcion}, Color: {auto.Color}, Fecha: {auto.Fecha}, Usado: {auto.Usado}, Importado: {auto.Importado}");
            }
        }
    }
    public class Auto
    {
        public int id { get; set; }
        public string Modelo { get; set; }
        public string Descripcion { get; set; }
        public string Color { get; set; }
        public DateTime Fecha { get; set; }
        public bool Usado { get; set; }
        public bool Importado { get; set; }

    }

    public class autoNegocio
    {
       public List<Auto> Listar()
        {
            List<Auto> Lista = new List<Auto>();
            Lista.Add(new Auto());
            Lista.Add(new Auto());

            Lista[0].id = 1;
            Lista[0].Modelo = "Peugeot 206";
            Lista[0].Descripcion = "Se La Re Banca";
            Lista[0].Color = "Rojo";
            Lista[0].Fecha = DateTime.Now;
            Lista[0].Usado = false;
            Lista[0].Importado = true;

            Lista[1].id = 2;
            Lista[1].Modelo = "Cruze";
            Lista[1].Descripcion = "Sin Palabras";
            Lista[1].Color = "Blanco";
            Lista[1].Fecha = DateTime.Now;
            Lista[1].Usado = true;
            Lista[1].Importado = true;

            return Lista;
        }






    }
}
