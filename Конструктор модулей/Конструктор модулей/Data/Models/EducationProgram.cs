using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Конструктор_модулей.Data.Models
{
    public class EducationProgram
    {
        // Образовательная программа по которому готовится модуль
        public int id { get; set; }

        public int lvlclass { get; set; }

        public string nameprog { get; set; }

        public string customer { get; set; }

        public string information { get; set; }
    }
}
