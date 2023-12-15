using ALoxe.Common;
using ALoxe.Infrastructure.DB;
using ALoxe.Infrastructure.Model;
using ALoxe.Infrastructure.Socket;
using ALoxe.Migrations.DataSeeder;
using ALoxe.UI;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ALoxe
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            //check app is running and kill
         
            ApplicationConfiguration.Initialize();

            //Application.Run(new frmMainWindow());

            //Application.Run(new frmBookingDetail(new Infrastructure.Data.Booking
            //{
            //    BookingDetailObj=new Infrastructure.Data.BookingDetail
            //    {
            //        Code="123",
            //    }
            //}));
            //return;


            var db = new AppDBContext();

            DataSeeder.SeedData();

            var loginForm = new frmLogin(db);
            loginForm.BringToFront();
            Application.Run(loginForm);
            var user = db.Users.ToList().FirstOrDefault();
            Socket.client = new SocketIOClient.SocketIO(Constant.APP_SERVER, new SocketIOClient.SocketIOOptions
            {
                Path = "/booking-event",
                Reconnection = true,
                ReconnectionDelay = 500,
                Transport = SocketIOClient.Transport.TransportProtocol.Polling | SocketIOClient.Transport.TransportProtocol.WebSocket,


            });
            if (loginForm.UserSuccessfullyAuthenticated)
            {

                Task.Run(async () =>
                {

                    Socket.client.On(user.Id.ToString(), response =>
                    {
                      

                    });
                    Socket.client.OnConnected += async (sender, e) =>
                    {
                        await Socket.client.EmitAsync("hi", "socket.io");
                    };
                    await Socket.client.ConnectAsync();
                }).Wait();
                Application.Run(new frmMainWindow());
            }

        }
    }
}