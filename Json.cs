using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace WindowsFormsApp20
{
    public static class Json
    {
        public static async Task saveAsync(List<TASK> list, string path)
        {
            var options = new JsonSerializerOptions()
            {
                WriteIndented = true
            };
            if (File.Exists(path))
                File.Delete(path);
            using (FileStream fs = new FileStream(path, FileMode.Create))
            {
                await System.Text.Json.JsonSerializer.SerializeAsync(fs, list, options);
                fs.Close();
            }
        }

        public static List<TASK> loadAsync(string path)
        {
            var options = new JsonSerializerOptions()
            {
                WriteIndented = true
            };
            var list = System.Text.Json.JsonSerializer.Deserialize<List<TASK>>(File.ReadAllText(path));
            return list;
        }
    }
}
