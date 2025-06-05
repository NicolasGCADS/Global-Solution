using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;

namespace SafeZoneMVP.Pages
{
    public class AlertasModel : PageModel
    {
        public List<PageAlertaModel> ListaAlertas { get; set; }

        public void OnGet()
        {
            // Simula dados (você pode buscar de um banco real)
            ListaAlertas = new List<PageAlertaModel>
            {
                new PageAlertaModel { Id = 1, Tipo = "Temperatura Alta", Descricao = "Área com Temperatura elevada, saia da área", DataHora = DateTime.Now },
                new PageAlertaModel { Id = 2, Tipo = "Fumaça", Descricao = "Área com Fumaça, possivel incendio, deixe a área", DataHora = DateTime.Now.AddMinutes(-10) },
                new PageAlertaModel { Id = 3, Tipo = "Umidade Baixa", Descricao = "Umidade Baixa, Área com possivel incendio", DataHora = DateTime.Now.AddDays(-10) },
                new PageAlertaModel { Id = 4, Tipo = "Fumaça", Descricao = "Área com Fumaça, possivel incendio, tenha cautela na área", DataHora = DateTime.Now.AddHours(-10) },
                new PageAlertaModel { Id = 5, Tipo = "Temperatura Alta", Descricao = "Área com Temperatura elevada, deixe a área", DataHora = DateTime.Now.AddMinutes(-30) },

            };
        }
    }
}
