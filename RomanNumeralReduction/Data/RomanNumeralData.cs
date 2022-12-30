using RomanNumeralReduction.Models;

namespace RomanNumeralReduction.Data
{
    public class RomanNumeralData
    {
        public List<RomanPattern> GetRomanNumeral()
        {
            var data = new List<RomanPattern>();
            var item = new RomanPattern();

            data.Add(new RomanPattern { RomanName = "I", RomanValue = 1});
            data.Add(new RomanPattern { RomanName = "V", RomanValue = 5 });
            data.Add(new RomanPattern { RomanName = "X", RomanValue = 10 });
            data.Add(new RomanPattern { RomanName = "L", RomanValue = 50 });
            data.Add(new RomanPattern { RomanName = "C", RomanValue = 100 });
            data.Add(new RomanPattern { RomanName = "D", RomanValue = 500 });
            data.Add(new RomanPattern { RomanName = "M", RomanValue = 1000 });

            return data;
        }
    }
}
