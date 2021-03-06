﻿using SimpleHttpServer;
using SimpleMVC;

namespace SharpStore
{
    class AppStart
    {
        static void Main(string[] args)
        {
            HttpServer server = new HttpServer(8081, RouteTable.Routes);
            MvcEngine.Run(server, "SharpStore");
        }
    }
}
