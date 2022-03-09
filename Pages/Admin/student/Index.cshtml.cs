using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using testEF;

namespace testEF.Pages.Admin.student
{
    [Authorize]
    public class IndexModel : PageModel
    {
        private readonly testEF.DataContext _context;

        public IndexModel(testEF.DataContext context)
        {
            _context = context;
        }

        public IList<Etudiant> Etudiant { get;set; }

        public async Task OnGetAsync()
        {
            Etudiant = await _context.Etudiants.ToListAsync();
        }
    }
}
