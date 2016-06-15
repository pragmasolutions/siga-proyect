using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DespachoAutomatico
{
    [DataContract]
    class CrearViaje
    {
        [DataMember]
        public string OK { get; set; }
        [DataMember]
        public int idViaje { get; set; }
    }
}
