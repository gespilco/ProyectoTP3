//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GDirectiva.Core.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class PlanAsignatura
    {
        public PlanAsignatura()
        {
            this.ActividadPlanAsignatura = new HashSet<ActividadPlanAsignatura>();
        }
    
        public int Id_PlanAsignatura { get; set; }
        public string Meta { get; set; }
        public string Metodologia { get; set; }
        public string Documento { get; set; }
        public Nullable<int> Id_PlanArea { get; set; }
        public Nullable<int> Id_Asignatura { get; set; }
        public Nullable<int> Id_Empleado { get; set; }
        public System.DateTime FechaCreacion { get; set; }
        public Nullable<System.DateTime> FechaModificacion { get; set; }
        public string Estado { get; set; }
    
        public virtual Empleado Empleado { get; set; }
        public virtual ICollection<ActividadPlanAsignatura> ActividadPlanAsignatura { get; set; }
        public virtual Asignatura Asignatura { get; set; }
        public virtual PlanArea PlanArea { get; set; }
    }
}
