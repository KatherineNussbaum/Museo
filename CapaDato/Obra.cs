//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CapaDato
{
    using System;
    using System.Collections.Generic;
    
    public partial class Obra
    {
        public string Codigo { get; set; }
        public string ArtistaRut { get; set; }
        public string Estilo { get; set; }
        public Nullable<long> Valor { get; set; }
        public string Dimensiones { get; set; }
        public string FechaCreacion { get; set; }
        public Nullable<System.DateTime> Procedencia { get; set; }
        public string Temperatura { get; set; }
        public string Humedad { get; set; }
        public string UbicacionSalon { get; set; }
    
        public virtual Persona Persona { get; set; }
        public virtual Ubicacion Ubicacion { get; set; }
    }
}
