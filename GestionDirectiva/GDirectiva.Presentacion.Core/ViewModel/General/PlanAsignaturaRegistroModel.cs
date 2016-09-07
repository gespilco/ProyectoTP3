﻿using GDirectiva.Core.Entities;
using GDirectiva.Core.Entities.General;
using GDirectiva.Presentacion.Core.ViewModel.Base;
using System.Collections.Generic;

namespace GDirectiva.Presentacion.Core.ViewModel.General
{
    public class PlanAsignaturaRegistroModel : GenericViewModel
    {
        public PlanAsignaturaRegistroModel()
        {
            this.planAsignatura = new PA_ASIGNATURA_PLANAREA_LISTA_Result();
        }

        public PA_ASIGNATURA_PLANAREA_LISTA_Result planAsignatura { get; set; }

        public List<PA_PERIODO_ACADEMICO_LISTA_VIGENTE_Result> ListaPeriodoAcademico = new List<PA_PERIODO_ACADEMICO_LISTA_VIGENTE_Result>();
    }
}
