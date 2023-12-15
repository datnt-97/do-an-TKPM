using ALoxe.Components;
using ALoxe.Infrastructure.Model;
using ALoxe.UI;
using BingMapsRESTToolkit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALoxe.Common
{
    public static class CrossThreadExtensions
    {
        public static void PerformSafely(this Control target, Action action)
        {
            if (target.InvokeRequired)
            {
                target.Invoke(action);
            }
            else
            {
                action();
            }
        }

        public static void PerformSafely<T1>(this Control target, Action<T1> action, T1 parameter)
        {
            if (target.InvokeRequired)
            {
                target.Invoke(action, parameter);
            }
            else
            {
                action(parameter);
            }
        }

        public static void PerformSafely<T1, T2>(this Control target, Action<T1, T2> action, T1 p1, T2 p2)
        {
            if (target.InvokeRequired)
            {
                target.Invoke(action, p1, p2);
            }
            else
            {
                action(p1, p2);
            }
        }
    }
    internal class UICommon
    {
        public static void ShowMapFrom2Point(ref ucMap mapALL, Microsoft.Maps.MapControl.WPF.Location locationFrom, Microsoft.Maps.MapControl.WPF.Location locationTo, Route route)
        {

            if (locationFrom != null)
            {

                //center map to location
                mapALL.myMap.Center = new Microsoft.Maps.MapControl.WPF.Location(locationFrom.Latitude, locationFrom.Longitude);
                //zoom level
                //Pushpin điểm A
                var pushpin = new Microsoft.Maps.MapControl.WPF.Pushpin();
                //thêm màu cho pushpin
                pushpin.Background = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Colors.Blue);
                pushpin.ToolTip = "Điểm đi";
                pushpin.Name = "A";
                //sự kiện click vào pushpin A sẽ hiển thị thông tin
                pushpin.MouseLeftButtonUp += (s, ev) =>
                {
                    var pin = s as Microsoft.Maps.MapControl.WPF.Pushpin;
                    if (pin != null)
                    {
                        var location = pin.Location;

                    }
                };
                pushpin.Location = locationFrom;
                mapALL.myMap.Children.Add(pushpin);
            }
            if (locationTo != null)
            {
                var pushpin = new Microsoft.Maps.MapControl.WPF.Pushpin();
                //thêm màu cho pushpin
                pushpin.Background = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Colors.Red);
                //sự kiện click vào pushpin B sẽ hiển thị thông tin
                pushpin.MouseLeftButtonUp += (s, ev) =>
                {
                    var pin = s as Microsoft.Maps.MapControl.WPF.Pushpin;
                    if (pin != null)
                    {
                        var location = pin.Location;

                    }
                };
                pushpin.Location = locationTo;
                mapALL.myMap.Children.Add(pushpin);

            }
            //zoom level with distance between 2 location 
            if (locationFrom != null && locationTo != null)
            {
                var distance = Common.Util.Distance(locationFrom, locationTo);
                if (distance < 100000)
                {
                    mapALL.myMap.ZoomLevel = 10;
                }
                else if (distance < 200000)
                {
                    mapALL.myMap.ZoomLevel = 9;
                }
                else if (distance < 300000)
                {
                    mapALL.myMap.ZoomLevel = 8;
                }
                else if (distance < 400000)
                {
                    mapALL.myMap.ZoomLevel = 7;
                }
                else if (distance < 500000)
                {
                    mapALL.myMap.ZoomLevel = 6;
                }
                else if (distance < 600000)
                {
                    mapALL.myMap.ZoomLevel = 5;
                }
                else if (distance < 700000)
                {
                    mapALL.myMap.ZoomLevel = 4;
                }
                else if (distance < 800000)
                {
                    mapALL.myMap.ZoomLevel = 3;
                }
                else if (distance < 900000)
                {
                    mapALL.myMap.ZoomLevel = 2;
                }
                else if (distance < 1000000)
                {
                    mapALL.myMap.ZoomLevel = 1;
                }
                else
                {
                    mapALL.myMap.ZoomLevel = 0;
                }

            }
            //route from addressFrom to addressTo
            if (route != null)
            {
                var routeLine = new Microsoft.Maps.MapControl.WPF.MapPolyline();
                routeLine.Locations = new Microsoft.Maps.MapControl.WPF.LocationCollection();
                foreach (var point in route.RoutePath.Line.Coordinates)
                {
                    routeLine.Locations.Add(new Microsoft.Maps.MapControl.WPF.Location(point[0], point[1]));
                    //tô màu đường đi
                    var color = System.Windows.Media.Colors.Red;
                    routeLine.Stroke = new System.Windows.Media.SolidColorBrush(color);
                    //độ dày đường đi
                    routeLine.StrokeThickness = 6;
                }
                mapALL.myMap.Children.Add(routeLine);
            }
        }
    }
}
