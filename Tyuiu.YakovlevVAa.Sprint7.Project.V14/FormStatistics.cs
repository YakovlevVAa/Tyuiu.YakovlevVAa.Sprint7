using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static Tyuiu.YakovlevVAa.Sprint7.Project.V14.FormMain;
using static Tyuiu.YakovlevVAa.Sprint7.Project.V14.FormStatistics;

namespace Tyuiu.YakovlevVAa.Sprint7.Project.V14
{
    public partial class FormStatistics : Form
    {
        private DataGridView _dataGridView;
        public FormStatistics(DataGridView dataGridView, int busCount, int minibusCount)
        {
            InitializeComponent();

            _dataGridView = dataGridView;
            CalculateStatistics();
            

        }
        private void CalculateStatistics()
        {
            var routes = new List<Route>();

            // Считываем данные из DataGridView
            foreach (DataGridViewRow row in _dataGridView.Rows)
            {
                if (row.IsNewRow) continue;

                var route = new Route
                {
                    TransportType = row.Cells[0].Value.ToString(),
                    RouteNumber = row.Cells[1].Value.ToString(),
                    StartStop = row.Cells[3].Value.ToString(),
                    EndStop = row.Cells[4].Value.ToString(),
                    TravelTime = TimeSpan.Parse(row.Cells[5].Value.ToString())
                };
                routes.Add(route);
            }

            // Статистика
            int totalRoutes = routes.Count;
            int busCount = routes.Count(r => r.TransportType == "Автобус");
            int minibusCount = routes.Count(r => r.TransportType == "Маршрутка");

            var routeGroups = routes.GroupBy(r => r.RouteNumber).ToList();
            var mostCommonRoute = routeGroups.OrderByDescending(g => g.Count()).FirstOrDefault();
            var leastCommonRoute = routeGroups.OrderBy(g => g.Count()).FirstOrDefault();

            var endStopGroups = routes.GroupBy(r => r.EndStop).ToList();
            var mostCommonEndStop = endStopGroups.OrderByDescending(g => g.Count()).FirstOrDefault();
            var leastCommonEndStop = endStopGroups.OrderBy(g => g.Count()).FirstOrDefault();

            var startStopGroups = routes.GroupBy(r => r.StartStop).ToList();
            var mostCommonStartStop = startStopGroups.OrderByDescending(g => g.Count()).FirstOrDefault();
            var leastCommonStartStop = startStopGroups.OrderBy(g => g.Count()).FirstOrDefault();

            // Вывод статистики
            labelTotalRoutes_YVA.Text = $"Общее количество маршрутов: {totalRoutes}";
            labelBusCount_YVA.Text = $"Количество автобусов: {busCount}";
            labelMiniBusCount_YVA.Text = $"Количество маршруток: {minibusCount}";
            labelMostCommonRoute_YVA.Text = $"Маршрут с максимальным количеством: {mostCommonRoute?.Key} ({mostCommonRoute?.Count()})";
            labelLeastCommonRoute_YVA.Text = $"Маршрут с минимальным количеством: {leastCommonRoute?.Key} ({leastCommonRoute?.Count()})";
            labelMostCommonEndStop_YVA.Text = $"Конечная остановка с максимальным количеством: {mostCommonEndStop?.Key} ({mostCommonEndStop?.Count()})";
            labelLeastCommonEndStop_YVA.Text = $"Конечная остановка с минимальным количеством: {leastCommonEndStop?.Key} ({leastCommonEndStop?.Count()})";
            labelMostCommonStartStop_YVA.Text = $"Начальная остановка с максимальным количеством: {mostCommonStartStop?.Key} ({mostCommonStartStop?.Count()})";
            labelLeastCommonStartStop_YVA.Text = $"Начальная остановка с минимальным количеством: {leastCommonStartStop?.Key} ({leastCommonStartStop?.Count()})";
            Series series = new Series
            {
                Name = "Доли видов транспорта",
                Color = System.Drawing.Color.Green,
                IsValueShownAsLabel = true,
                ChartType = SeriesChartType.Pie
            };
            series.Points.AddXY("Автобусы", busCount);
            series.Points.AddXY("Маршрутки", minibusCount);
            chartTime_YVA.Series.Add(series);
            chartTime_YVA.Titles.Add("Соотношение автобусов и маршруток");



        }
       



        public class Route
        {
            public string TransportType { get; set; }
            public string RouteNumber { get; set; }
            public string StartStop { get; set; }
            public string EndStop { get; set; }
            public TimeSpan TravelTime { get; set; }

        } 



    }
}

