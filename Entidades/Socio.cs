using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Socio
    {

        private static int last_id;
        //VER COMO SE ASIGNA ID
        private int id;
        private int dni;
        private string nombre;
        private string apellido;
        private string nombreUsuario;
        private string contrasenia;


        private static int next_id()
        {
            
            Socio.last_id = Socio.last_id + 1;
            return Socio.last_id;
        }
        public Socio( int dni, string nombre, string apellido, string nombreUsuario, string contrasenia)
        {
            
            this.id = Socio.next_id();
            Dni = dni;
            Nombre = nombre;
            Apellido = apellido;
            NombreUsuario = nombreUsuario;
            Contrasenia = contrasenia;
        }
        
        public Boolean ContraseniaValida(string contra_a_validar)
        {
            return this.contrasenia == contra_a_validar;
        }
        public int Id {
            get
            {
                return this.id;
            }
        }
        public string Apellido
        { 
            get;set;
        }


        public string Nombre
        {
            get; set;
        }

        public int Dni
        {
            get; set;
        }

        public string Contrasenia
        {
            get;
            set
            {
                this.contrasenia = value;
            }
        }

        public string NombreUsuario
        {
            get; set;
        }
    }
}