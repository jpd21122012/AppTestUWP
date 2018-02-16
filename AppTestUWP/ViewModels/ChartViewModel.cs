using System;
using System.Collections.ObjectModel;

using AppTestUWP.Helpers;
using AppTestUWP.Models;
using AppTestUWP.Services;

namespace AppTestUWP.ViewModels
{
    public class ChartViewModel : Observable
    {
        public ChartViewModel()
        {
        }

        public ObservableCollection<DataPoint> Source
        {
            get
            {
                // TODO WTS: Replace this with your actual data
                return SampleDataService.GetChartSampleData();
            }
        }
    }
}
