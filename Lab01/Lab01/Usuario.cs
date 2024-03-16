using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    public class Usuario
    {
        public string Nombre { get; set; }
        public double Saldo { get; set; }

        public Usuario(string nombre, double saldo)
        {
            Nombre = nombre;
            Saldo = saldo;
        }

        public Usuario()
        {
        }

        public virtual void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {Nombre}, Saldo: {Saldo}");
        }
    }

    public class Cliente : Usuario
    {
        public double LitrosCargados { get; set; }

        public Cliente(string nombre, double saldo, double litrosCargados) : base(nombre, saldo)
        {

            LitrosCargados = litrosCargados;
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Litros Cargados: {LitrosCargados}");
        }
    }

    public class Empleado : Usuario
    {
        public double Sueldo { get; set; }

        public Empleado(string nombre, double saldo, double sueldo) : base(nombre, saldo)
        {
            Sueldo = sueldo;
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Sueldo: {Sueldo}");
        }
    }

    public class Grifo
    {
        private List<Usuario> usuarios;

        public Grifo()
        {
            usuarios = new List<Usuario>();
        }

        public void AgregarUsuario(Usuario usuario)
        {
            usuarios.Add(usuario);
        }

        public void MostrarUsuarios()
        {
            foreach (var usuario in usuarios)
            {
                usuario.MostrarInformacion();
            }
        }
    }

}
