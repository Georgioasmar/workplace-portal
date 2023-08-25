using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

namespace Business.Models
{
    public class Functions
    {
        public static string CapitalizeFirstLetterOfWords(string input)
        {
            string Tinput = input.Trim();
            TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
            return textInfo.ToTitleCase(Tinput);
        }
    }
}
