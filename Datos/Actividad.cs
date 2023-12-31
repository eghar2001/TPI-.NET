﻿using Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Actividad
    {


        public List<Entidades.Actividad> findAll()
        {
            using (var context = new ApplicationDbContext())
            {
                return context.Actividades.ToList();
            }
        }
        public Entidades.Actividad? get(int actividad_id)
        {
            using (var context = new ApplicationDbContext())
            {
                return context.Actividades.FirstOrDefault(a => a.Id == actividad_id);
            }
        }

        public void agregarActividad(Entidades.Actividad actividad_nueva)
        {
            using (var context = new ApplicationDbContext())
            {


                context.Add(actividad_nueva);
                context.Add(new ValorActividad()
                {
                    Precio = actividad_nueva.UltimoPrecio,
                    Actividad = actividad_nueva
                });
                context.SaveChanges();
            }
        }
        public Entidades.Actividad? findByNombre(string nombre)
        {
            using (var context = new ApplicationDbContext())
            {
                return context.Actividades.FirstOrDefault(a => a.Nombre == nombre);
            }
        }
        public void modificarActividad(Entidades.Actividad actividad_modificada)
        {
            Entidades.Actividad actividad_original = get(actividad_modificada.Id);

            using (var context = new ApplicationDbContext())
            {
                context.Update(actividad_modificada);
                if (actividad_original.UltimoPrecio != actividad_modificada.UltimoPrecio)
                {
                    context.Add(new ValorActividad()
                    {
                        ActividadId = actividad_modificada.Id,
                        Precio = actividad_modificada.UltimoPrecio
                    });
                }
                context.SaveChanges();

            }

        }
        public void borrar_actividad(Entidades.Actividad actividad_a_borrar)
        {
            using (var context = new ApplicationDbContext())
            {
                context.Remove(actividad_a_borrar);
                context.SaveChanges();
            }
        } 

        public List<Entidades.ValorActividad> find_valores_actividad(int id_actividad)
        {
            using(var context = new ApplicationDbContext())
            {
                List<Entidades.ValorActividad> valores_actividad = context.ValoresActividad.Where(v => v.ActividadId == id_actividad).OrderBy(v => v.FechaDesde).ToList();
                return valores_actividad;
            }
                
        }

    }
}
