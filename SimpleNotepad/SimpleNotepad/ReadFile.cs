using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SimpleNotepad
{
    public class ReadFile
    {
        private StreamReader reader;
        private string filepath = null;

        public ReadFile(string path)
        {
            filepath = path;
        }
        public string GetFile()
        {
            string line = null;
            try
            {
                reader = new StreamReader(filepath);
                line = reader.ReadToEnd();
            }
            catch(FileNotFoundException fnfex)
            {
                throw fnfex;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return line;
        }
    }
}
