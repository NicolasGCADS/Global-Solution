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
                new PageAlertaModel { Id = 1, Tipo = "Erro", Descricao = "Falha ao carregar módulo", DataHora = DateTime.Now },
                new PageAlertaModel { Id = 2, Tipo = "Aviso", Descricao = "Atualização disponível", DataHora = DateTime.Now.AddMinutes(-10) }
            };
        }
    }
}
