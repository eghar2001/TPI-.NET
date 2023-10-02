﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WinForm
{
    public class Validaciones
    {
        public static  bool EsPrecio(string campo_precio)
        {
            Regex precioRegex = new Regex(@"^\d+([\.\,]\d{1,2})?$");
            return precioRegex.IsMatch(campo_precio);
        }
        public static bool TieneLargoMaximo(string campo, int largo)
        {
            return campo.Length <= largo;
        }
        public static bool EsHoraMin(string horaMin)
        {
            Regex horaMinRegex = new Regex(@"^\d{2}:\d{2}$"); 
            if (horaMinRegex.IsMatch(horaMin)){
                int hora = Convert.ToInt32(horaMin.Substring(0,2));
                int minutos = Convert.ToInt32(horaMin.Substring(3, 2));
                return (hora <= 23 && hora >= 0) && (minutos >= 0 && minutos <= 59);
            }
            return false;
        }
    }
}
