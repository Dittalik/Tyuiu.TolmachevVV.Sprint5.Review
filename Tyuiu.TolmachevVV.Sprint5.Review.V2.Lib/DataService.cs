using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.TolmachevVV.Sprint5.Review.V2.Lib
{
    public class DataService : ISprint5Task7V2
    {
        public string LoadDataAndSave(string path)
        {
            string outputpath = $@"{Directory.GetCurrentDirectory()}\OutPutDataFileTask7V2.txt";
            using (StreamReader reader = new StreamReader(path))
            {
                string content = reader.ReadToEnd();
                for (int i = 0; i < content.Length; i++)
                {
                    if (int.TryParse(content[i].ToString(), out int number))
                    {
                        content = content.Replace(content[i], '#');
                    }
                }
                File.WriteAllText(outputpath, content);
            }
            return outputpath;
        }
    }
}
