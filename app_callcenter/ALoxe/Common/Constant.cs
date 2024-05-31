using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALoxe.Common
{
    internal class Constant
    {
        private static string HOST = ConfigurationManager.AppSettings["Host"];
        private static string PORT = ConfigurationManager.AppSettings["Port"];
        private static string PORT_SOCKET = ConfigurationManager.AppSettings["ScoketPort"];

        private static string SSL = ConfigurationManager.AppSettings["SSL"];
        public static string MAP_KEY = ConfigurationManager.AppSettings["BING_MAP_KEY"];

        //get app.config 
        public static string APP_SERVER = string.Format("{0}://{1}:{2}", SSL == "true" ? "https" : "http", HOST, PORT);
        public static string APP_SERVER_SOCKET = string.Format("{0}://{1}:{2}", SSL == "true" ? "https" : "http", HOST, PORT_SOCKET);

        public static string URL_BOOKING = "/api/orders";
        public static string URL_SEARCH_CUSTOMER = "/api/customers";
        public static string URL_BOOKING_DETAIL = URL_BOOKING;
        public static string URL_LOGIN = "/api/auth/login";


    }
}
