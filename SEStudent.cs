using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareEngineering
{
    internal class SEStudent
    {
        public string Name {  get; set; }
        public string LanguageOfProgramming { get; set; }
        public SEStudent(string name, string languageOfProgramming)
        {
            Name = name;
            LanguageOfProgramming = languageOfProgramming;
        }
        public override string ToString()
        {
            return Name + ". Знает " + LanguageOfProgramming;
        }
    }
}
