using System.ComponentModel;

namespace Tyuiu.YakovlevVAa.Sprint7.Project.V14.Lib
{
    public class DataService
    {

        public List<string[]> LoadCsvData(string filePath)
        {
            var data = new List<string[]>();

            // Чтение CSV файла
            var lines = File.ReadAllLines(filePath);
            foreach (var line in lines)
            {
                var values = line.Split(',');
                data.Add(values);
            }

            return data;
        }

        public List<object[]> ProcessData(List<string[]> rawData)
        {
            var processedData = new List<object[]>();

            foreach (var line in rawData)
            {
                var processedRow = new object[line.Length];

                for (int i = 0; i < line.Length; i++)
                {
                    string cellValue = line[i];

                    // Обработка третьего столбца
                    if (i == 2) // Третий столбец (индекс 2)
                    {
                        if (DateTime.TryParse(cellValue, out DateTime date))
                        {
                            processedRow[i] = date.Date.ToShortDateString(); // Сохраняем только дату
                        }
                        else
                        {
                            processedRow[i] = DBNull.Value; // Если не удалось преобразовать, оставляем пустым
                        }
                    }
                    
                    
                    else
                    {
                        processedRow[i] = cellValue; // Обычные значения
                    }
                }

                processedData.Add(processedRow);
            }

            return processedData;
        }
        
    }
}

    

