//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Innova.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Competencia
    {
        public Competencia()
        {
            this.Capacidad = new HashSet<Capacidad>();
            this.CurriculaBaseCompetencia = new HashSet<CurriculaBaseCompetencia>();
            this.DetalleCurricula = new HashSet<DetalleCurricula>();
        }
    
        public int IdCompetencia { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
    
        public virtual ICollection<Capacidad> Capacidad { get; set; }
        public virtual ICollection<CurriculaBaseCompetencia> CurriculaBaseCompetencia { get; set; }
        public virtual ICollection<DetalleCurricula> DetalleCurricula { get; set; }
    }
}
