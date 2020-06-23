using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Xaml.Shapes;


// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace TestPoline
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
          //  this.Loaded += MainPage_Loaded;
        }

        private void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            //var ttv = polyline1.TransformToVisual(canvas);
            //Point screenCoords = ttv.TransformPoint(new Point(0, 0));

            //try
            //{
            //    var polyline1 = canvas.Children.FirstOrDefault(x => x.GetType().Name == typeof(Polyline).Name);
            //    Debug.Write($"fullname: {polyline1.GetType().FullName}");
            //    Debug.Write($"is polyline: {polyline1 is Polyline}");
            //    Debug.Write($"as polyline: {polyline1 as Polyline}");
            //    Debug.Write($"as polyline.ActualOffset.X: {(polyline1 as Polyline).ActualOffset.X}");
            //}
            //catch (Exception ex)
            //{
            //    Debug.Write($"error: {ex}");
            //}
        }
    }
}
