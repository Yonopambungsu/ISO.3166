using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ISOLib_3166_1_2
{
    public class Country
    {
        public int Id { get; set; }
        public string Alpha2 { get; set; } = string.Empty;
        public string Alpha3 { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;

    }
}
