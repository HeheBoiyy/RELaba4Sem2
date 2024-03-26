using System.Text;

namespace Logic
{
    public class Logical
    {
        public static Dictionary<int,string> GetPhrace()
        {
            Dictionary<int,string> temp = new Dictionary<int, string> ();
            string path = "save.txt";
            var srcEncoding = Encoding.GetEncoding("UTF-8");
            using (StreamReader reader = new StreamReader(path,encoding:srcEncoding))
            {
                string? line;
                int i = 0;
                while (i<4)
                {
                    line = reader.ReadLine();
                    if (line == null)
                    {
                        temp.Add(i, "");
                    }
                    else 
                    {
                        line = line.Trim();
                        temp.Add(i, line);
                    }

                    i++;
                }
            }
            return temp;
        }
        public static void Save(string str1,string str2,string str3,string str4)
        {
            string path = "save.txt";
            var srcEncoding = Encoding.GetEncoding("UTF-8");
            using (StreamWriter sr = new StreamWriter(path,false))
            {
                sr.WriteLine(str1);
                sr.WriteLine(str2);
                sr.WriteLine(str3);
                sr.WriteLine(str4);
            };
        }
        public static string GenerateText(int length,bool israndom,string register)
        {
            int TargetLength = length;
            string generatedstr = "";
            string final = "";
            Dictionary<int,string> temp = GetPhrace();
            if (israndom)
            {
                while (generatedstr.Split(". ").Length <= TargetLength)
                {
                    Random randstr = new Random();
                    string tempstring = temp[randstr.Next(4)];
                    Random randword = new Random();
                    for(int i = 0;i<randstr.Next(3,9);i++)
                    {
                        generatedstr += tempstring.Split(" ")[randword.Next(tempstring.Split(" ").Length)]+" ";
                    }
                    generatedstr += ". ";
                }
            }
            else
            {
                for (int i = 0; i < TargetLength; i++) 
                {
                    generatedstr += temp[i % 4]+". ";
                }
            }
            if (register == "Нижний Регистр")
            {
                final = generatedstr.ToLower();
            }
            else if (register =="Верхний Регистр")
            {
                final = generatedstr.ToUpper();
            }
            else if (register == "Заглавная буква + нижний Регистр")
            {
                foreach(string s in generatedstr.Split(". "))
                {
                    if (string.IsNullOrEmpty(s)) continue;
                    final += char.ToUpper(s[0]) + s.Substring(1).ToLower()+". ";
                }
            }
            return final;
        }

        public static int GetTotalCharacters(string input)
        {
            string[] sentences = input.Split('.');

            return  input.Replace(" ", "").Replace(".", "").Length;
            
        }
        public static int GetTotalWords(string input)
        {
            
            return input.Split(new char[] { ' ', '.' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }
        public static int GetUniqueWords(string input)
        {
            return input.Split(new char[] { ' ', '.' }, StringSplitOptions.RemoveEmptyEntries)
                                  .Select(word => word.ToLower())
                                  .Distinct()
                                  .ToArray()
                                  .Length;
        }
        public static List<(string,int)> GetTop5Words(string input)
        {
            List<string> wordsList = input.Split(new char[] { ' ','.' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            Dictionary<string, int> wordFrequency = new Dictionary<string, int>();
            foreach (var word in wordsList)
            {
                if (wordFrequency.ContainsKey(word))
                {
                    wordFrequency[word]++;
                }
                else
                {
                    wordFrequency.Add(word, 1);
                }
            }

            var top5Words = wordFrequency.OrderByDescending(x => x.Value).Take(5).ToDictionary(x => x.Key, x => x.Value);

            return top5Words.Select(kv => (kv.Key, kv.Value)).ToList();

        }

    }
}
