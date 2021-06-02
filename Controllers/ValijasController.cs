using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using api.Utils;
using api.CRUD; 
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Models.Traffic;
using api.Models.DTOs;
using api.Models;
using System;
using Microsoft.Extensions.Logging;
namespace api.Controllers
{
    public class ValijasController : BaseApiController
    {


        private readonly GlobalContext _context;
        public ValijasController(GlobalContext context){
            _context = context;
        }

        [HttpPost("agregar-valijas")]
        public async Task<ActionResult<Valija>> AddValija(Valija nuevasValijas)
        {
            _context.Valijas.AddRange(nuevasValijas);

            await _context.SaveChangesAsync();
            return nuevasValijas;
        }

        // [HttpGet("lista-valijas")]
        // public async Task<ActionResult<IEnumerable<Valija>>> getValijas()
        // {
        //     return await _context.Valijas.ToListAsync();
        // }

        [HttpPost("lista-valijas/{destino}")]
        public async Task<ActionResult<IEnumerable<RutaValijas>>> getValijasDestino(string destino)
        {
            var query = // Ensure `query` is `IQueryable<T>` instead of using `IEnumerable<T>`. But this code has to use `var` because its type-argument is an anonymous-type.
            from r in _context.Rutas
            join v in _context.Valijas
            on r.Id equals v.RutaId
            where v.Destino == destino
            select new RutaValijas{ 
                Id = v.Id, 
                CodigoValija = v.Codigo,
                Origen = v.Origen,
                Destino = v.Destino,
                Peso_Excedente = v.Peso_Excedente,
                CodigoRuta = r.Codigo,
                RutaId = v.RutaId
            };

            // var list = await query.ToListAsync().ConfigureAwait(false); // <-- notice the `await` here. And always use `ConfigureAwait`.
            return await query.ToListAsync().ConfigureAwait(false);
            
        }

        // // [HttpPost("lista-rutas/{id}")]
        // // public async Task<ActionResult<Ruta>> getRutaById(int id){
        // //      return await _context.Rutas.FindAsync(id);
        // // }


        // [HttpPost("agregar-ruta")]
        // public async Task<ActionResult<Ruta>> AddRuta(Ruta nuevaRuta)
        // {
            
        //     var ruta = new Ruta{
        //         Codigo = nuevaRuta.Codigo,
        //         Tipo_Ruta = nuevaRuta.Tipo_Ruta,
        //         Turno = nuevaRuta.Turno,
        //         Estado_Ruta = 1, //default 1 activado,
        //         UserId = nuevaRuta.UserId
        //     };

        //     _context.Rutas.Add(ruta);

        //     await _context.SaveChangesAsync();
        //     return ruta;
        // }

        // [HttpPut("actualizar-ruta")]
        // public ActionResult<Ruta> UpdateRuta(Ruta rutaActualizada){
        //     var ruta = new Ruta();
        //     Console.WriteLine(rutaActualizada.Codigo);
        //     ruta = _context.Rutas.FirstOrDefault(x => x.Id == rutaActualizada.Id);

        //     ruta.Codigo = rutaActualizada.Codigo;
        //     ruta.Tipo_Ruta = rutaActualizada.Tipo_Ruta;
        //     ruta.Turno = rutaActualizada.Turno;
        //     ruta.Estado_Ruta = rutaActualizada.Estado_Ruta;
        //     ruta.UserId = rutaActualizada.UserId;
            
        //     _context.SaveChanges();
        //     return ruta;
        // }
    }
}