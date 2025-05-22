using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fase3JhonArdila
{
    internal class EstructuraDatosUsuario
    {
        public string tipoDocumento {  get; set; }
        public string numeroIdentidad { get; set; }
        public string nombreUsuario { get; set; }
        public int edadUsuario { get; set; }
        public string estratoUsuario { get; set; }
        public string atencionRequerida {  get; set; }
        public int valorCopago {  get; set; }
        public string fechaDeRegistro {  get; set; }
    }
}
