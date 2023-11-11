using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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



        [Key]
        public int Id { get; set;  }


        [Required]
        public string Apellido
        {
            get; set;
        } = null!;

        [Required]
        public string Nombre
        {
            get; set;
        }=null!;

        [Required]
        public int Dni
        {
            get; set;
        }

        [Required]
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

        [Required]
        public string NombreUsuario
        {
            get; set;
        } = null!;

        [Required]
        [ForeignKey("TipoUsuario")]
        public int TipoUsuarioId { get; set; }

        public TipoUsuario TipoUsuario { get; set; } = null!;

        [NotMapped]
        public string NombreApellido
        {
            get
            {
                return this.Nombre + " " + this.Apellido;
            }
        }
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

        public override string ToString()
        {
            return this.NombreUsuario;
        }
    }
}