using System;
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
    }
}
