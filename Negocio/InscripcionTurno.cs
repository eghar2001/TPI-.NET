using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class InscripcionDadaDeBajaException : Exception
    {
        public InscripcionDadaDeBajaException(string message) : base(message) { }
    }
    public class CupoMaximoException : Exception
    {
        public CupoMaximoException(string message) : base(message) { }
    }
    public class UsuarioYaInscriptoException : Exception
    {
        public UsuarioYaInscriptoException(string message) : base(message) { }
    }
    public class InscripcionTurno
    {
        private Datos.InscripcionTurno datos_inscripcionTurno = new Datos.InscripcionTurno();
        private Datos.Turno datos_turno = new Datos.Turno();
        private Datos.Usuario datos_usuario = new Datos.Usuario();

        public List<Entidades.InscripcionTurno> find_all(int idUsuario)
        {
            return datos_inscripcionTurno.find_all(idUsuario);
        }

        public void agregarInscripcionTurno(Entidades.InscripcionTurno inscripcionTurno_nuevo)
        {

            Entidades.Turno? turno = datos_turno.get_one(inscripcionTurno_nuevo.TurnoId);
            if (turno == null)
            {
                throw new ArgumentException("No se encontro el turno");
            }
            int cantidad_inscriptos = datos_turno.cantidadInscripcionesVigentes(turno.Id);
            if (cantidad_inscriptos + 1 > turno.Cupo)
            {
                throw new CupoMaximoException("Se llego al cupo maximo posible");
            }
            List<Entidades.Actividad> actividades_inscriptas = datos_usuario.actividadesInscriptasDelSocio(inscripcionTurno_nuevo.UsuarioId);
            bool usuario_esta_inscripto = actividades_inscriptas.FirstOrDefault(a => a.Id == turno.ActividadId) != null;
            if (usuario_esta_inscripto)
            {
                throw new UsuarioYaInscriptoException("El usuario ya esta inscripto a la actividad solicitada");
            }
            datos_inscripcionTurno.agregarInscripcionTurno(inscripcionTurno_nuevo);
        }
        
        

        public void darDeBajaInscripcionTurno(int id_inscripcion)
        {
            Entidades.InscripcionTurno? inscripcionTurno = datos_inscripcionTurno.get_one(id_inscripcion);
            if (inscripcionTurno == null)
            {
                throw new ArgumentException("No se ingresó un id existente");
            }
            if (inscripcionTurno.DadoDeBaja)
            {
                throw new InscripcionDadaDeBajaException("La inscripcion ya se encuentra dada de baja");
            }
            inscripcionTurno.DarDeBaja();
            datos_inscripcionTurno.actualizarInscripcionTurno(inscripcionTurno);
        }
    }
}
