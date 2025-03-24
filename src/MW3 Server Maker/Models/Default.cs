using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MW3_Server_Maker
{
    public class Default
    {
        private readonly string _path;
        public readonly List<string> Rotations;

        public Default(string path)
        {
            _path = path;
            Rotations = new List<string>();
        }

        public void Add(string map, string mod, int priority)
        {
            Rotations.Add($"{map}, {mod}, {priority}");
        }

        public void Read()
        {
            string[] lines = File.ReadAllLines(_path);
            foreach (var line in lines)
            {
                if (!string.IsNullOrEmpty(line) && !line.StartsWith("//"))
                    Rotations.Add(line);
            }
        }

        public void Write()
        {
            byte[] bytes = Properties.Resources.Default;
            string content = Encoding.UTF8.GetString(bytes, 0, bytes.Length);
            StringBuilder sb = new StringBuilder();
            using (StringWriter sw = new StringWriter(sb))
            {
                sw.Write(content);
                foreach (var line in Rotations)
                    sw.WriteLine(line);
            }
            File.WriteAllText(_path, sb.ToString());
        }
    }
}
