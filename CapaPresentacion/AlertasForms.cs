using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    class AlertasForms
    {
        public static Boolean ValidarTxtBoxFormulario(Control Objeto, ErrorProvider ErrorProvider)
        {
            Boolean ExistenErrores = false;
            foreach (Control Item in Objeto.Controls)
            {
                if (Item is AlertaVacioTxtBox)
                {
                    AlertaVacioTxtBox Obj = (AlertaVacioTxtBox)Item;
                    if (Obj.ValidarAlertaTxtBox == true)
                    {
                        if (string.IsNullOrEmpty(Obj.Text.Trim()))
                        {
                            ErrorProvider.SetError(Obj, "No puede estar vacio");
                            ExistenErrores = true;
                        }
                    }
                    else
                    {
                        ErrorProvider.SetError(Obj, "");
                    }
                }
            }
            return ExistenErrores;
        }
    }
}
