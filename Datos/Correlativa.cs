//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Datos
{
    using System;
    using System.Collections.Generic;
    
    public partial class Correlativa
    {
        public int idCorrelativa { get; set; }
        public Nullable<int> idMateria { get; set; }
        public string Nombre { get; set; }
        public string Requisito { get; set; }
    
        public virtual Materia Materia { get; set; }
    }
}
