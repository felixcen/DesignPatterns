using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.SOLID
{
    public class Journal
    {
        private readonly IList<string> _entries;
        private int _count = 0;
        public Journal()
        {
            _entries = new List<string>();
        }

        public int AddEntry(string entry)
        {
            _entries.Add($"{++_count}:{entry}");
            return _count;
        }

        public void RemoveEntry(int index)
        {
            _entries.RemoveAt(index);
        }

        public override string ToString()
        {
            return string.Join(Environment.NewLine, _entries); 
        }
    }
}
