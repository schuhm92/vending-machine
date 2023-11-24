using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using VendingMachine.Data;
using VendingMachine.Models;

namespace vending_machine.Pages_Products
{
    public class IndexModel : PageModel
    {
        private readonly VendingMachine.Data.ProductContext _context;

        public IndexModel(VendingMachine.Data.ProductContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Product = await _context.Product.ToListAsync();
        }
    }
}
