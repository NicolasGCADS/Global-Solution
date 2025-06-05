using Microsoft.AspNetCore.Mvc.RazorPages;
using SafeZoneMVP.Models;
using System;
using System.Collections.Generic;

namespace SafeZoneMVP.Pages
{
    public class UsuarioModel : PageModel
    {
        public List<PageUsuarioModel> ListaUsuarios { get; set; }

        public void OnGet()
        {
            // Simula dados (você pode buscar de um banco real)
            ListaUsuarios = new List<PageUsuarioModel>
            {
                new PageUsuarioModel { Id = 1, Email = "Bruno@gmail", Password = "1234@ALO", Role = "USER" },
                new PageUsuarioModel { Id = 2, Email = "Alan@fiap", Password = " Al982732 ", Role = "USER" },
                new PageUsuarioModel { Id = 3, Email = "Nicolas@gmail", Password = " DEWS2343 ", Role = "ADMIN" },
                new PageUsuarioModel { Id = 4, Email = "Guilherme@gmail", Password = " 574832gui ", Role = "ADMIN" },
                new PageUsuarioModel { Id = 5, Email = "Paola@gmail", Password = " 2354323@Po ", Role = "USER" }
            };
        }
    }
}
