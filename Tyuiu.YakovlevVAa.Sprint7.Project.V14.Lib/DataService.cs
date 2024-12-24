using System.ComponentModel;

namespace Tyuiu.YakovlevVAa.Sprint7.Project.V14.Lib
{
    public class DataService
    {

        public List<string[]> LoadDataFromFile(string path)
        {
            List<string[]> csvData = new List<string[]>();
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while((line = sr.ReadLine()) != null)
                {
                    string[] values = line.Split(',');
                    csvData.Add(values);
                }
            }
            return csvData;
        }
    }
}

    

