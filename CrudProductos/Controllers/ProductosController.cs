using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CrudProductos.Data;
using CrudProductos.Models;

namespace CrudProductos.Controllers
{
    public class ProductosController : Controller
    {
        private readonly AppDbContext _context;

        public ProductosController(AppDbContext context)
        {
            _context = context;
        }
    }
}
