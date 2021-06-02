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
    public class RutasController : BaseApiController
    {
        RutaHelper rutaHelper = new RutaHelper();
        private readonly GlobalContext _context;
        public RutasController(GlobalContext context){
            _context = context;
        }
      

        [HttpGet("lista-rutas")]
        public async Task<ActionResult<IEnumerable<Ruta>>> getRutas()
        {
            return await _context.Rutas.ToListAsync();
        }

        [HttpPost("lista-rutas/{id}")]
        public async Task<ActionResult<IEnumerable<RutaUsers>>> getRutas(int id)
        {
            var query = // Ensure `query` is `IQueryable<T>` instead of using `IEnumerable<T>`. But this code has to use `var` because its type-argument is an anonymous-type.
            from r in _context.Rutas
            join u in _context.Users
            on r.UserId equals u.Id
            where r.UserId == id
            select new { 
                r.Id,
                r.Codigo,
                r.Tipo_Ruta,
                r.UserId,
                u.Nombre,
                u.Apellido,
                r.Turno,
                r.Estado_Ruta
            };

            var list = await query.ToListAsync().ConfigureAwait(false); // <-- notice the `await` here. And always use `ConfigureAwait`.
            return list
            .Select( r => new RutaUsers() {
                Id = r.Id, 
                Codigo = r.Codigo,
                Tipo_Ruta = r.Tipo_Ruta,
                UserId = r.UserId,
                UserNombre = r.Nombre,
                UserApellido = r.Apellido,
                Turno = r.Turno,
                Estado_Ruta = r.Estado_Ruta
            } )
            .ToList();
            
        }


        [HttpPost("agregar-ruta")]
        public async Task<ActionResult<Ruta>> AddRuta(Ruta nuevaRuta)
        {
            
            var ruta = new Ruta{
                Codigo = nuevaRuta.Codigo,
                Tipo_Ruta = nuevaRuta.Tipo_Ruta,
                Turno = nuevaRuta.Turno,
                Estado_Ruta = 1, //default 1 activado,
                UserId = nuevaRuta.UserId
            };

            _context.Rutas.Add(ruta);

            await _context.SaveChangesAsync();
            return ruta;
        }

        [HttpPut("actualizar-ruta")]
        public ActionResult<Ruta> UpdateRuta(Ruta rutaActualizada){
            var ruta = new Ruta();
            Console.WriteLine(rutaActualizada.Codigo);
            ruta = _context.Rutas.FirstOrDefault(x => x.Id == rutaActualizada.Id);

            ruta.Codigo = rutaActualizada.Codigo;
            ruta.Tipo_Ruta = rutaActualizada.Tipo_Ruta;
            ruta.Turno = rutaActualizada.Turno;
            ruta.Estado_Ruta = rutaActualizada.Estado_Ruta;
            ruta.UserId = rutaActualizada.UserId;
            
            _context.SaveChanges();
            return ruta;
        }

    }
}
