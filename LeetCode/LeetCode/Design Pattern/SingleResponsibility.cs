using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Design_Pattern
{
    public class SingleResponsibility
    {
        private readonly List<string> entries = new List<string>();

        private static int count = 0;
        public int AddEntry(string text)
        {
            entries.Add($"{++count}: {text}");
            return count; // memento
        }

        public void RemoveEntry(int index)
        {
            entries.RemoveAt(index);
        }

        public override string ToString()
        {
            return string.Join(Environment.NewLine, entries);
        }

    }

    public class Persistence
    {
        public void SaveToFile(SingleResponsibility j, string filename, bool overwrite = false)
        {
            if (overwrite || File.Exists(filename))
            {
                if(overwrite || !File.Exists(filename))
                    File.WriteAllText(filename, j.ToString());
            }
        }
    }
}
