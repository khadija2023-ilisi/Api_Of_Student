using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using testEF;

namespace testEF.Pages.student
{
    
    public class Index1Model : PageModel
    {
       
        private readonly testEF.DataContext _context;

        public Index1Model(testEF.DataContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            if (User.Identity.IsAuthenticated)
            {
                return Redirect("/Admin/student");
            }
            return Page();
        }
        public async Task<IActionResult> OnPost(string username, string password, string ReturnUrl)
        {
            
            if (username == "admin")
            {
                var claims = new List<Claim> { new Claim(ClaimTypes.Name, username) };

                var claimsIdentity = new ClaimsIdentity(claims, "Login");
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.
                AuthenticationScheme, new ClaimsPrincipal(claimsIdentity));
                return Redirect(ReturnUrl == null ? "/Admin/student/Create" : ReturnUrl);
            }
            return Page();
        }
    }
    
}
