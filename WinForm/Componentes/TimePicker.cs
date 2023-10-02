using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm.Componentes
{
    public partial class TimePicker : UserControl
    {
        private int hora = 0;
        private int minutos = 0;

        public string HoraMinutos
        {
            get
            {
                string horastr = Convert.ToString(hora);
                if (horastr.Length < 2)
                {
                    horastr = "0" + horastr;
                }
                string minstr = Convert.ToString(minutos);
                if (minstr.Length < 2)
                {
                    minstr = "0" + minstr;
                }
                return horastr + ":" + minstr;
            }
            set
            {
                if (!Validaciones.EsHoraMin(value))
                {
                    throw new ArgumentException("No se ingresó una hora valida");
                }
                int hora_value = Convert.ToInt32(value.Substring(0, 2));
                int min_value = Convert.ToInt32(value.Substring(3, 2));
                AsignarHora(hora_value);
                AsignarMinutos(min_value);
            }

        }
        public TimePicker()
        {
            InitializeComponent();


            this.HoraMinutos = "00:00";
        }


        private void txtHora_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar)))
            {

                e.Handled = true;
            }
        }
        private void txtHora_TextChanged(object sender, EventArgs e)
        {
            if (this.txtHora.Text == "" || this.txtHora.Text == null)
            {
                return;
            }
            AsignarHora(Convert.ToInt32(txtHora.Text));
        }
        private void txtMinutos_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!(Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
        private void txtMinutos_TextChanged(object sender, EventArgs e)
        {
            if (this.txtMinutos.Text == "" || this.txtMinutos.Text == null)
            {
                return;
            }
            AsignarMinutos(Convert.ToInt32(txtMinutos.Text));
        }
        

        private void btnSubirHora_Click(object sender, EventArgs e)
        {

            SubirHora();
        }
        private void btnBajarHora_Click(object sender, EventArgs e)
        {
            BajarHora();
        }

        private void btnSubirMinuto_Click(object sender, EventArgs e)
        {
            SubirMinutos();
        }

        private void btnBajarMinuto_Click(object sender, EventArgs e)
        {
            BajarMinutos();
        }

        private bool AsignarHora(int hora)
        {
            if (hora >= 0 && hora <= 23)
            {
                this.hora = hora;
                this.txtHora.Text = hora.ToString();
                return true;
            }
            else
            {
                this.txtHora.Text = this.hora.ToString();
                return false;

            }

        }
        private bool AsignarMinutos(int minutos)
        {
            if (minutos >= 0 && minutos <= 59)
            {
                this.minutos = minutos;
                this.txtMinutos.Text = minutos.ToString();
                return true;
            }
            else
            {
                this.txtMinutos.Text = this.minutos.ToString();
                return false;
            }
            
        }
        private bool SubirHora()
        {
            if (this.hora + 1 <= 23)
            {
                this.hora += 1;
                this.txtHora.Text = Convert.ToString(this.hora);
                return true;
            }
            return false;
        }
        private bool BajarHora()
        {
            if (this.hora - 1 >= 0)
            {
                this.hora -= 1;
                this.txtHora.Text = Convert.ToString(this.hora);
                return true;
            }
            return false;
        }

        private void SubirMinutos()
        {
            if (this.minutos + 1 <= 59)
            {
                this.minutos += 1;
                this.txtMinutos.Text = Convert.ToString(this.minutos);
            }
            else
            {
                if (SubirHora())
                {
                    AsignarMinutos(0);
                }
            }
        }
        private void BajarMinutos()
        {
            if (this.minutos - 1 >= 0)
            {
                this.minutos -= 1;
                this.txtMinutos.Text = Convert.ToString(this.minutos);
            }
            else
            {
                if (BajarHora())
                {
                    AsignarMinutos(59);
                }
            }
        }

        
    }
}
