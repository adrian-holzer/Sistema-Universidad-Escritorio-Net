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
    
    public partial class Final
    {
        public int intIdFinal { get; set; }
        public int idCursoMateria { get; set; }
        public Nullable<int> NotaExamen { get; set; }
        public string EstadoEFinal { get; set; }
    
        public virtual CursoMateria CursoMateria { get; set; }
    }
}
