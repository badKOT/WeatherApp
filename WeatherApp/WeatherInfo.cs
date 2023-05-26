using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp
{
    class WeatherInfo
    {
        /// <summary>
        /// root есть базовый класс, в котором содержатся все остальные.
        /// классы weather, main, wind соответствуют частям в полученном
        /// json-е, поля внутри классов соответствуют полям внутри частей
        /// в полученном json-е. все неиспользуемые значения не сохраняются.
        /// </summary>
        public class weather
        {
            public string main { get; set; }
        }
        public class main
        {
            public double temp { get; set; }
        }
        public class wind
        {
            public double speed { get; set; }
        }

        public class root
        {
            public List<weather> weather { get; set; }
            public main main { get; set; }
            public wind wind { get; set; }
        }
    }
}
