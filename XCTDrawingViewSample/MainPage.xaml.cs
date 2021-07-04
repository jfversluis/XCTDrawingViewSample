using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.CommunityToolkit.UI.Views;
using Xamarin.Forms;

namespace XCTDrawingViewSample
{
    public partial class MainPage : ContentPage
    {
        public Command DrawCompleted { get; set; }

        public MainPage()
        {
            InitializeComponent();

            DrawCompleted = new Command(() =>
            {
                theImage.Source = ImageSource.FromStream(() => drawing.GetImageStream(500, 500));
            });

            BindingContext = this;
        }

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            var myPoints = new ObservableCollection<Point>();

            for(int i = 0; i < 2000; i++)
            {
                myPoints.Add(new Point(i, i));
            }

            drawing.Points = myPoints;
        }
    }
}
