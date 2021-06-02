using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using api.Utils;
using api.CRUD; 
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Models.Traffic;
using api.Models;
using System;
using Microsoft.Extensions.Logging;

namespace api.Controllers
{
    public class UsersController : BaseApiController
    {private readonly GlobalContext _context;
        public UsersController(GlobalContext context){
            _context = context;
        }

        // [HttpGet("lista-usuarios/{id}")]
        // public async Task<ActionResult<IEnumerable<Ruta>>> getUsers(int id)
        // {
        //     var query = // Ensure `query` is `IQueryable<T>` instead of using `IEnumerable<T>`. But this code has to use `var` because its type-argument is an anonymous-type.
        //     from r in _context.Rutas
        //     join u in _context.Users
        //     on r.UserId equals u.Id
        //     where r.UserId == id
        //     select new { 
        //         r.Id,
        //         r.Codigo,
        //         r.Tipo_Ruta,
        //         r.UserId,
        //         r.Turno,
        //         r.Estado_Ruta
        //     };

        //     var list = await query.ToListAsync().ConfigureAwait(false); // <-- notice the `await` here. And always use `ConfigureAwait`.
        //     return list
        //     .Select( r => new Ruta() {
        //         Id = r.Id, 
        //         Codigo = r.Codigo,
        //         Tipo_Ruta = r.Tipo_Ruta,
        //         UserId = r.UserId,
        //         Turno = r.Turno,
        //         Estado_Ruta = r.Estado_Ruta
        //     } )
        //     .ToList();
            
        // }
        
        
    }
}