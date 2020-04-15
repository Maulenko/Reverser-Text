using System;
using System.Collections.Generic;

namespace Reverser_Text
{
    public class Translit
    {
        Dictionary<string, string> dictionaryCharEngToRus = new Dictionary<string, string>()
            {
                        {"q","й"},
                        {"Q","Й"},
                        {"w","ц"},
                        {"W","Ц"},
                        {"e","у"},
                        {"E","У"},
                        {"r","к"},
                        {"R","К"},
                        {"t","е"},
                        {"T","Е"},
                        {"y","н"},
                        {"Y","Н"},
                        {"u","г"},
                        {"U","Г"},
                        {"i","ш"},
                        {"I","Ш"},
                        {"o","щ"},
                        {"O","Щ"},
                        {"p","з"},
                        {"P","З"},
                        {"[","х"},
                        {"{","Х"},
                        {"]","ъ"},
                        {"}","Ъ"},
                        {"a","ф"},
                        {"A","Ф"},
                        {"s","ы"},
                        {"S","Ы"},
                        {"d","в"},
                        {"D","В"},
                        {"f","а"},
                        {"F","А"},
                        {"g","п"},
                        {"G","П"},
                        {"h","р"},
                        {"H","Р"},
                        {"j","о"},
                        {"J","О"},
                        {"k","л"},
                        {"K","Л"},
                        {"l","д"},
                        {"L","Д"},
                        {";","ж"},
                        {":","Ж"},
                        {"'","э"},
                        {"\"","Э"},
                        {"z","я"},
                        {"Z","Я"},
                        {"x","ч"},
                        {"X","Ч"},
                        {"c","с"},
                        {"C","С"},
                        {"v","м"},
                        {"V","М"},
                        {"b","и"},
                        {"B","И"},
                        {"n","т"},
                        {"N","Т"},
                        {"m","ь"},
                        {"M","Ь"},
                        {",","б"},
                        {"<","Б"},
                        {".","ю"},
                        {">","Ю"},
                        {"/","."},
                        {"?",","}
            };

        Dictionary<string, string> dictionaryCharRusToEng = new Dictionary<string, string>()
            {
                        {"й","q"},
                        {"Й","Q"},
                        {"ц","w"},
                        {"Ц","W"},
                        {"у","e"},
                        {"У","E"},
                        {"к","r"},
                        {"К","R"},
                        {"е","t"},
                        {"Е","T"},
                        {"н","y"},
                        {"Н","Y"},
                        {"г","u"},
                        {"Г","U"},
                        {"ш","i"},
                        {"Ш","I"},
                        {"щ","o"},
                        {"Щ","O"},
                        {"з","p"},
                        {"З","P"},
                        {"х","["},
                        {"Х","{"},
                        {"ъ","]"},
                        {"Ъ","}"},
                        {"ф","a"},
                        {"Ф","A"},
                        {"ы","s"},
                        {"Ы","S"},
                        {"в","d"},
                        {"В","D"},
                        {"а","f"},
                        {"А","F"},
                        {"п","g"},
                        {"П","G"},
                        {"р","h"},
                        {"Р","H"},
                        {"о","j"},
                        {"О","J"},
                        {"л","k"},
                        {"Л","K"},
                        {"д","l"},
                        {"Д","L"},
                        {"ж",";"},
                        {"Ж",":"},
                        {"э","'"},
                        {"Э","\""},
                        {"я","z"},
                        {"Я","Z"},
                        {"ч","x"},
                        {"Ч","X"},
                        {"с","c"},
                        {"С","C"},
                        {"м","v"},
                        {"М","V"},
                        {"и","b"},
                        {"И","B"},
                        {"т","n"},
                        {"Т","N"},
                        {"ь","m"},
                        {"Ь","M"},
                        {"б",","},
                        {"Б","<"},
                        {"ю","."},
                        {"Ю",">"},
                        {".","/"},
                        {",","?"}
            };

        public string TranslitEng(string sourceEng)
        {
            var result = "";
            foreach (var ch in sourceEng)
            {
                var ss = "";
                if (dictionaryCharEngToRus.TryGetValue(ch.ToString(), out ss))
                {
                    result += ss;
                }
                else result += ch;
            }
            return result;
        }
        public string TranslitRus(string source)
        {
            var result = "";
            foreach (var ch in source)
            {
                var ss = "";
                if (dictionaryCharRusToEng.TryGetValue(ch.ToString(), out ss))
                {
                    result += ss;
                }
                else result += ch;
            }
            return result;
        }
    }
}
