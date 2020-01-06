using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using 字符分割.Properties;
namespace 字符分割
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            TextInfos(TextInfo.Textmodels());
            Console.ReadKey();
        }



      public static void TextInfos(List<model> models)
        {
            var v = from s in models select new { s.text };
            string texts = "";
            foreach (var ss in v)
            {
                texts = texts + ss;
            }

            string[] strArr = Regex.Split(texts, "人工智能", RegexOptions.IgnoreCase);
            List<string> strtext = new List<string>();
            foreach (var s in strArr)
            {
                strtext.Add(s);
            }
            foreach (var s in strtext)
            {
                string c = "人工智能" + s + "\n";
                int i = 1;
                foreach (char r in c)
                {
                    Console.Write(r);
                    i++;
                    if (i == 13)
                    {
                        Console.WriteLine("...");
                        break;
                    }

                }

            }



        //public static void Ss(List<model> infos)
        //{
        //    List<string> strtxt = new List<string>();
        //    string txt = "";
        //    foreach(string ss in strtxt)
        //    {
        //        txt += strtxt;
        //    }
        //    string[] strAdd = Regex.Split(txt, "人工智能", RegexOptions.IgnoreCase);
        //    Console.WriteLine(strtxt);

        //}

        //        List<string> strtext = new List<string>();
        //        string[] sr = File.ReadAllLines(@"/Users/oujinhong/Desktop/vs/01/TextRead/EmptyTextFile.txt");
        //        string text = "";
        //            foreach (string s in sr)
        //            {
        //                text += s;
        //            }
        //    string[] strArr = Regex.Split(text, "人工智能", RegexOptions.IgnoreCase);
        //            foreach (var s in strArr)
        //            {
        //                strtext.Add(s);
        //            }
        //            foreach (var s in strtext)
        //            {
        //                string c = "人工智能" + s + "\n";
        //int i = 1;
        //                foreach(char r in c)
        //                {
        //                    Console.Write(r);
        //                    i++;
        //                    if (i==13)
        //                    {
        //                        Console.WriteLine("...");
        //                        break;
        //                    }

        //                }
    }
}
    }
