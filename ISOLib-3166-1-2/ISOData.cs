using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ISOLib_3166_1_2
{
    public static class ISOData
    {
        public static List<Country> Countries { get; } = Load<Country>("ISOLib_3166_1_2.countries.json");
        public static List<Subdivision> Subdivisions { get; } = Load<Subdivision>("ISOLib_3166_1_2.subdivisions.json");

        private static List<T> Load<T>(string resourceName)
        {
            var assembly = Assembly.GetExecutingAssembly();

            using Stream stream = assembly.GetManifestResourceStream(resourceName)
                ?? throw new FileNotFoundException($"Embedded resource '{resourceName}' not found.");

            using StreamReader reader = new StreamReader(stream);
            string json = reader.ReadToEnd();

            return JsonSerializer.Deserialize<List<T>>(json, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            }) ?? new List<T>();
        }
    }
}
