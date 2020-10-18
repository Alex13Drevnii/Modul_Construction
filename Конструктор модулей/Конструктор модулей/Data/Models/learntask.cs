using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Конструктор_модулей.Data.Models
{
    //Задачи внутри модуля
    public class learntask
    {
        public string nametask { get; set; }

        public string texttask { get; set; }

        public List<string> imglink { get; set; }

        public string task { get; set; }

        public string dopinfo { get; set; }

        public List<List<string>> tegsinfo { get; set; }
    }
}
