using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SMT_lab_08.Data;
using SMT_lab_08.Models;

namespace SMT_lab_08.Pages.Products
{
    public class IndexModel : PageModel
    {
        private readonly ProductRepository _repository;

        public IndexModel(ProductRepository repository)
        {
            _repository = repository;
        }

        public List<Product> Products { get; set; } = new();

        public async Task OnGetAsync()
        {
            Products = await _repository.GetAllAsync();
        }
    }
}