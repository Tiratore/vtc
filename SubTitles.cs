using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VTC
{
    public struct SubTitles
    {
        public TimeSpan startTime; //Начало показа
        public TimeSpan stopTime; //Конец показа
        public string text; //Текст титра
    }
}
