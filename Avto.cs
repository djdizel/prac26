using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PRACTICUM26
{
    internal class Avto
    {
        /// <summary>
        /// поля
        /// </summary>
        string name;
        int release_date;
        public static int summary;
        /// <summary>
        /// инкапсуляция полей
        /// </summary>
        public string Name 
        {
            get { return name; }
            set { name = value; }
        }

        public int Release_date 
        { 
            get { return release_date; }
            set { release_date = value; }
        }
        //public static int Summary 
        //{ 
        //    get { return summary; }
        //    set { summary = value; }
        //}
        /// <summary>
        /// конструктор без параметров
        /// </summary>
        public Avto() { }
        /// <summary>
        /// конструктор с параметрами
        /// </summary>
        /// <param name="name"></param>
        /// <param name="release_date"></param>
        public Avto(string name, int release_date)
        {
            this.Name = name;
            this.Release_date = release_date;
            summary++;
        }
        /// <summary>
        /// Вывод
        /// </summary>
        /// <returns></returns>
        //public override string ToString()
        //{
        //    return $"Модель:{Name}\nГод выпуска:{Release_date}\nОбщее кол-во автомобилей:{summary}";
        //}
    }
}
