using ALoxe.Infrastructure.Data;
using ALoxe.Infrastructure.Http;
using ALoxe.UI;
using BingMapsRESTToolkit;
using Microsoft.Maps.MapControl.WPF;
using Microsoft.VisualBasic.ApplicationServices;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Controls;

namespace ALoxe.Common
{
    public class Util
    {
        //check email valid
        private static string KEY_MAP = Constant.MAP_KEY;
        public static bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static async Task<Microsoft.Maps.MapControl.WPF.Location> GetLocationFromAddressAsync(string address)
        {
            //sử dụng api bing map để lấy tọa độ từ địa chỉ
            var request = new GeocodeRequest();
            request.BingMapsKey = KEY_MAP;

            request.Query = address;

            Response result = await request.Execute();

            if (result.StatusCode == 200)
            {
                var toolkitLocation = (result?.ResourceSets?.FirstOrDefault())
                        ?.Resources?.FirstOrDefault()
                        as BingMapsRESTToolkit.Location;
                var latitude = toolkitLocation.Point.Coordinates[0];
                var longitude = toolkitLocation.Point.Coordinates[1];
                var mapLocation = new Microsoft.Maps.MapControl.WPF.Location(latitude, longitude);
                return mapLocation;
            }
            return null;

        }

        //GetRouteFromAddressAsync
        public static Route GetRouteFromAddressAsync(string fromAddress, string toAddress)
        {
            //sử dụng api bing map để lấy tọa độ từ địa chỉ
            var request = new RouteRequest();
            request.BingMapsKey = KEY_MAP;

            request.Waypoints = new List<SimpleWaypoint>()
            {
                new SimpleWaypoint(fromAddress),
                new SimpleWaypoint(toAddress)
            };

            request.RouteOptions = new RouteOptions()
            {
                RouteAttributes = new List<RouteAttributeType>()
                {
                    RouteAttributeType.RoutePath
                }
            };

            Response result = null;
            Task.Run(async () =>
           {
               result = await request.Execute();
           }).Wait();
            if (result.StatusCode == 200)
            {
                var route = (result?.ResourceSets?.FirstOrDefault())
                        ?.Resources?.FirstOrDefault()
                        as Route;
                return route;
            }
            return null;

        }
        public static async Task<Route> GetRoute2PointAsync(Microsoft.Maps.MapControl.WPF.Location fromLocation, Microsoft.Maps.MapControl.WPF.Location toLocation)
        {
            //sử dụng api bing map để lấy tọa độ từ địa chỉ
            var request = new RouteRequest();
            request.BingMapsKey = KEY_MAP;

            request.Waypoints = new List<SimpleWaypoint>()
            {
                new SimpleWaypoint(new Coordinate(fromLocation.Latitude,fromLocation.Longitude)),
                new SimpleWaypoint(new Coordinate(toLocation.Latitude,toLocation.Longitude))
            };

            request.RouteOptions = new RouteOptions()
            {
                RouteAttributes = new List<RouteAttributeType>()
                {
                    RouteAttributeType.RoutePath
                }
            };

            Response result = await request.Execute();

            if (result.StatusCode == 200)
            {
                var route = (result?.ResourceSets?.FirstOrDefault())
                        ?.Resources?.FirstOrDefault()
                        as Route;
                return route;
            }
            return null;

        }
        public static double Distance(Microsoft.Maps.MapControl.WPF.Location l1, Microsoft.Maps.MapControl.WPF.Location l2)
        {
            var R = 6371e3; // metres
            var φ1 = l1.Latitude * Math.PI / 180; // φ, λ in radians
            var φ2 = l2.Latitude * Math.PI / 180;
            var Δφ = (l2.Latitude - l1.Latitude) * Math.PI / 180;
            var Δλ = (l2.Longitude - l1.Longitude) * Math.PI / 180;

            var a = Math.Sin(Δφ / 2) * Math.Sin(Δφ / 2) +
                    Math.Cos(φ1) * Math.Cos(φ2) *
                    Math.Sin(Δλ / 2) * Math.Sin(Δλ / 2);
            var c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));

            var d = R * c; // in metres
            return d;
        }
        public static async Task SearchAddress(string address)
        {
            HttpRequest_v2 client = new HttpRequest_v2();
            var url = $"http://dev.virtualearth.net/REST/v1/Autosuggest?query={address}&key={KEY_MAP}";
            var response = await client.SendAsync(url, HttpMethod.Get);
            var res = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode)
            {
                //get resourceSets
                var result = JsonConvert.DeserializeObject<dynamic>(res);
                var resourceSets = result.resourceSets;
                var resources = resourceSets.resources[0].value;

            }
        }

        public static async Task<Booking> GetBookingAsync(string id)
        {
            HttpRequest_v2 httpRequest = new HttpRequest_v2();

            var response = await httpRequest.SendAsync(Constant.APP_SERVER + Constant.URL_BOOKING_DETAIL + '/' + id, HttpMethod.Get);
            if (response.IsSuccessStatusCode)
            {
                var res = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<Result>(res, new JsonSerializerSettings
                {
                    NullValueHandling = NullValueHandling.Ignore,
                });
                if (result.status == "SUCCESS")
                {
                    try
                    {
                        var list = JsonConvert.DeserializeObject<Booking>(JsonConvert.SerializeObject(result.data
                                                       , new JsonSerializerSettings
                                                       {
                                                           NullValueHandling = NullValueHandling.Ignore,
                                                       }), new JsonSerializerSettings
                                                       {
                                                           NullValueHandling = NullValueHandling.Ignore,
                                                       });
                        //đưa dữ liệu vào datagridview
                        return list;
                    }
                    catch (Exception ex)
                    {

                    }
                    //.Select(b=>b.ToObject<Booking>()).ToList();// result.data as List<Booking>;
                }

            }
            return null;

        }

        public static async Task<List<Booking>> GetBookingsAsync(int userId = 0, string txt = "", bool isBooking = true)
        {
            HttpRequest_v2 httpRequest = new HttpRequest_v2();

            var response = await httpRequest.SendAsync(Constant.APP_SERVER + Constant.URL_BOOKING + $"?{(userId == 0 ? "" : "staffId=" + userId)}{(txt == "" ? "" : "&search=" + txt)}{(!isBooking ? "&status=" + BookingStatus.BOOKED.ToString() : "")}", HttpMethod.Get);
            if (response.IsSuccessStatusCode)
            {
                var res = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<Result>(res, new JsonSerializerSettings
                {
                    NullValueHandling = NullValueHandling.Ignore,
                });
                if (result.status == "SUCCESS")
                {
                    try
                    {
                        var list = JsonConvert.DeserializeObject<List<Booking>>(JsonConvert.SerializeObject(result.data
                            , new JsonSerializerSettings
                            {
                                NullValueHandling = NullValueHandling.Ignore,
                            }), new JsonSerializerSettings
                            {
                                NullValueHandling = NullValueHandling.Ignore,
                            });
                        //đưa dữ liệu vào datagridview
                        return list;
                    }
                    catch (Exception ex)
                    {

                    }
                    //.Select(b=>b.ToObject<Booking>()).ToList();// result.data as List<Booking>;
                }

            }
            return new List<Booking>();

        }
    }
}
