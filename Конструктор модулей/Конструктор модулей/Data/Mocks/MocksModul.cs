using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Конструктор_модулей.Data.Interfaces;
using Конструктор_модулей.Data.Models;

namespace Конструктор_модулей.Data.Mocks
{
    public class MocksModul : IBuildModul {
        private readonly IBuildModul _ModulNew = new MocksModul();
        public Modul getobjectModul()
        {
            throw new NotImplementedException();
        }
    }
}
