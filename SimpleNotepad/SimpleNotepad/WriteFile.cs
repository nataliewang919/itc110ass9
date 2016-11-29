using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SimpleNotepad
{
    class WriteFile
    {
        private StreamWriter writer;
        string filepath = null;

        public WriteFile(string path)
        {
            try
            {
                filepath = path;
                writer = new StreamWriter(path, true);
            }
          
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void AddText(string line)
        {
            writer.Write(line);
        }

        public void CloseFile()
        {
            writer.Close();
        }
    }
}
