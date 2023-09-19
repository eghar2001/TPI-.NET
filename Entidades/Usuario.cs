using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Entidades
{
    public class Usuario
    {

        
        private int id;
        private int dni;
        private string nombre;
        private string apellido;
        private string nombreUsuario;
        private string contrasenia;


         
        public Usuario( int id,int dni, string nombre, string apellido, string nombreUsuario, string contrasenia)
        {

            this.id = id;
            Dni = dni;
            Nombre = nombre;
            Apellido = apellido;
            NombreUsuario = nombreUsuario;
            Contrasenia = contrasenia;
        }

        public Usuario(int dni, string nombre, string apellido, string nombreUsuario, string contrasenia)
        {

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
            get; set;
        } = null!;


        public string Nombre
        {
            get; set;
        }=null!;

        public int Dni
        {
            get; set;
        } 

        public string Contrasenia
        {
            get {
                return this.contrasenia;
            }
            set
            {
                this.contrasenia = value;
            }
        } 

        public string NombreUsuario
        {
            get; set;
        } = null!;
        public int TipoUsuarioId { get; set; }

        public bool EsTipoUsuario(TiposUsuarioEnum tipo) 
        {
            if (tipo == TiposUsuarioEnum.EMPLEADO)
            {
                return this.TipoUsuarioId == 2;
            }
            else if(tipo == TiposUsuarioEnum.SOCIO) 
            {
                return this.TipoUsuarioId == 1;
            }
            else
            {
                return false;
            }
        }
    }
}