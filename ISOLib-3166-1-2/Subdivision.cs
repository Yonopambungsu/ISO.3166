using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text.Json;

namespace ISOLib_3166_1_2
{
    public class Subdivision
    {
        public string Country { get; set; } = string.Empty;
        public string Code { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
        public string Parent { get; set; } = string.Empty;

    }
}
