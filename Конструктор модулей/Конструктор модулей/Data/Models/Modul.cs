using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Конструктор_модулей.Data.Models
{
    /*
     * Прописываем класс модулей
     * Используется для создания новых модулей и демонстрации шаблона уже существующих
     */
    public class Modul
    {
        //Основные данные модуля
        public int id { get; set; }

        public string nameeducmod { get; set; }

        public string predmet { get; set; }

        public string lvlclass { get; set; }

        public int workhours { get; set; }

        public List<List<string>> learnaim{ get; set; }

        public string resFGOS { get; set; }

        public string instteach { get; set; }

        public string commodul { get; set; }

        public List<List<string>> typeassdis { get; set; }

        public string difficult { get; set; }
        
        //Мотивационный блок
        public string baseidea { get; set; }

        public string problemq { get; set; }

        public string videoinf { get; set; }

        public string textinf { get; set; }

        public string testinf { get; set; }

        public string imginf { get; set; }

        public string audioinf { get; set; }

        public string nametask { get; set; }

        public string texttask { get; set; }

        public List<string> taskinfo { get; set; }

        public List<string> systask { get; set; }

        //Задания
        public List<learntask> listtask { get; set; }
    }
}
