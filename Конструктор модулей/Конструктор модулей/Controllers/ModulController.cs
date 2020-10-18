using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Конструктор_модулей.Data.Interfaces;

namespace Конструктор_модулей.Controllers
{
    public class ModulController : Controller 
    {
        private readonly IBuildModul _newModul;
        
        public ModulController(IBuildModul buildModul)
        {
            _newModul = buildModul;
        }

        public ViewResult modulhtml()
        {
            var modul = _newModul.getobjectModul();
            return View();
        }
    }
}
