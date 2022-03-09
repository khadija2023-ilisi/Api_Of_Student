using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace testEF.Pages
{
    public class IndexModel : PageModel
    {
        DataContext dataContext ;

       

        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger,DataContext dc)
        {
            _logger = logger;
            dataContext = dc;
        }

        public void OnGet()
        {
            //Etudiant etu= new Etudiant() { nom = "Adami", prenom = "Mouad" };
            //dataContext.Etudiants.Add(etu);
            dataContext.SaveChanges();
        }
    }
}
