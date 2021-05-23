using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Diakok.Model;
using Diakok.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Diakok.Pages.DiakokLista
{
    public class DiakokListaModel : PageModel
    {
        private readonly DiakService _diakService;

        [BindProperty]
        public Diak diak { get; set; }
       

        public DiakokListaModel(DiakService productService)
        {
            _diakService = productService;
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            //await _diakService.CreateProduct(Diak);

            return RedirectToPage("Index");
        }
    }
}
