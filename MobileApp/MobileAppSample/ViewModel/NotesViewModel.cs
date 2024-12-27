using System;
using System.Collections.ObjectModel;

namespace MobileAppSample.ViewModel;

public class DesignItem
{
    public string? Title { get; set; }
    public Color? Textcolor { get; set; }
    public string? BackgroundColor { get; set; }
    public List<string>? AvatarImages { get; set; }
    public string? Date { get; set; }
    public int GridRow { get; set; }
    public int GridColumn { get; set; }
    public int GridRowSpan { get; set; }
    public int GridColumnSpan { get; set; }
}
public class MainViewModel
{
    public ObservableCollection<DesignItem> Items { get; set; }
    public MainViewModel()
    {
        Items = new ObservableCollection<DesignItem> {
            new() {
                Title = "Design \nSystem \nComponents",
				Textcolor= Colors.White,
                BackgroundColor = "#684CF0",
                AvatarImages = new List<string> { "people_circle1i.png", "people_circle2i.png", "people_circle3i.png" },
                Date = "May 21",
                GridRow = 0,
                GridColumn = 0,
				GridRowSpan=1,
				GridColumnSpan=1,
            },
            new() {
                Title = "Interaction \nDesign \nPrinciples",
				Textcolor= Colors.Black,
                BackgroundColor = "#CBD87E",
                AvatarImages = [ "people_circle1i.png", "people_circle2i.png"],
                GridRow = 0,
                GridColumn = 1,
				GridRowSpan=1,
				GridColumnSpan=1,
            },
			 new() {
                Title = "Onboarding Experience \nEnhancement",
				Textcolor= Colors.Black,
                BackgroundColor = "#F9CD62",
                AvatarImages = [ "people_circle1i.png", "people_circle2i.png", "people_circle3i.png", "people_circle4i.png"],
                GridRow = 1,
                GridColumn = 0,
				GridRowSpan=1,
				GridColumnSpan=2,
            },
			 new() {
                Title = "Responsive \nDesign \nStrategies",
				Textcolor= Colors.White,
                BackgroundColor = "#EC5951",
                AvatarImages = [ "people_circle1i.png", "people_circle2i.png" ],
                GridRow = 2,
                GridColumn = 0,
				GridRowSpan=2,
				GridColumnSpan=1,
            },
			 new() {
                Title = "Information \nArchitecture",
                BackgroundColor = "#CBD87E",
                AvatarImages = [ "people_circle1i.png" ],
                GridRow = 2,
                GridColumn = 1,
				GridRowSpan=1,
				GridColumnSpan=1,
            },
			 new() {
                Title = "Typography \nand \nReadabilty",
                BackgroundColor = "#5CC397",
                AvatarImages = [ "people_circle1i.png"],
                GridRow = 4,
                GridColumn = 0,
				GridRowSpan=1,
				GridColumnSpan=1,
            },
			 new() {
                Title = "Usabilty \nTesting \nFeedback",
                BackgroundColor = "#684CF0",
                AvatarImages = [ "people_circle1i.png", "people_circle2i.png", "people_circle3i.png"],
                GridRow = 3,
                GridColumn = 1,
				GridRowSpan=2,
				GridColumnSpan=1,
            },
		};
    }
}

