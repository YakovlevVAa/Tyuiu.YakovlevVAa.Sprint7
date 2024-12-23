namespace Tyuiu.YakovlevVAa.Sprint7.Project.V14.Lib
{
    public class DataService
    {
        public static List<Route> ReadRoutesFromCsv(string filePath)
        {
            var routes = new List<Route>();
            foreach (var line in File.ReadLines(filePath).Skip(1)) // Пропускаем заголовок
            {
                var columns = line.Split(',');
                routes.Add(new Route
                {
                    TransportType = columns[0],
                    RouteNumber = columns[1],
                    StartDate = DateTime.Parse(columns[2]),
                    StartStop = columns[3],
                    EndStop = columns[4],
                    TravelTime = TimeSpan.Parse(columns[5]),
                    Notes = columns[6]
                });
            }
            return routes;
        }
    }
    public class Route
    {
        public string TransportType { get; set; }
        public string RouteNumber { get; set; }
        public DateTime StartDate { get; set; }
        public string StartStop { get; set; }
        public string EndStop { get; set; }
        public TimeSpan TravelTime { get; set; }
        public string Notes { get; set; }
        public static void WriteRoutesToCsv(string filePath, List<Route> routes)
        {
            using (var writer = new StreamWriter(filePath))
            {
                writer.WriteLine("TransportType,RouteNumber,StartDate,StartStop,EndStop,TravelTime,Notes");
                foreach (var route in routes)
                {
                    writer.WriteLine($"{route.TransportType},{route.RouteNumber},{route.StartDate},{route.StartStop},{route.EndStop},{route.TravelTime},{route.Notes}");
                }
            }
        }
    }
}
    

