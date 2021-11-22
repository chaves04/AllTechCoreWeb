using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AllTechCoreWeb.Controllers
{
    public class CadastroController : Controller
    {
        private readonly dao.Contexto _oContexto;

        public CadastroController( dao.Contexto pContexto )
        {
            _oContexto = pContexto;
        }

        public IActionResult Index()
        {
            List<Models.Cadastro> lstCadastro = _oContexto.Cadastro.ToList<Models.Cadastro>();
            return View( lstCadastro );

        }
        public IActionResult excluir( int id )
        {
            Models.Cadastro oExcluir = _oContexto.Cadastro.FirstOrDefault<Models.Cadastro>( x => x.ID == id );

            _oContexto.Remove( oExcluir );
            _oContexto.SaveChanges();

            return RedirectToAction( "index" );
        }
        public IActionResult novo()
        {
            return View( new Models.Cadastro() );
        }
        [HttpPost]
        public IActionResult novo( Models.Cadastro pForm )
        {
            if ( ModelState.IsValid )
            {
                _oContexto.Cadastro.Add( pForm );
                _oContexto.SaveChanges();

                return RedirectToAction( "index" );
            }
            else
                return View();
        }
        public IActionResult editar( int id )
        {
            Models.Cadastro oCadastro = _oContexto.Cadastro.First( c => c.ID == id );
            return View( oCadastro );
        }
        [HttpPost]
        public IActionResult editar( Models.Cadastro pForm )
        {
            if ( ModelState.IsValid )
            {
                _oContexto.Cadastro.Update( pForm );
                _oContexto.SaveChanges();

                return RedirectToAction( "index" );
            }
            else
                return View();
        }

    }
}
