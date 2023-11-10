using LiveChartsCore.SkiaSharpView.Extensions;
using LiveChartsCore;
using System.Collections.Generic;

namespace LiteSystemProfiler.ViewModels;

public class MainViewModel : ViewModelBase
{
    public string Greeting => "Welcome to Avalonia!";

    public IEnumerable<ISeries> Series { get; set; } =
        GaugeGenerator.BuildSolidGauge(
            new GaugeItem(
                30,          // the gauge value
                series =>    // the series style
                {
                    series.MaxRadialColumnWidth = 50;
                    series.DataLabelsSize = 50;
                }));
}
