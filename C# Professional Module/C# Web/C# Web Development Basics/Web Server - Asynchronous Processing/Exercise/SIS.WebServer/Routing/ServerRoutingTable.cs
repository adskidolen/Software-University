﻿namespace SIS.WebServer.Routing
{
    using SIS.Http.Enums;
    using SIS.Http.Requests.Contracts;
    using SIS.Http.Responses.Contracts;

    using System;
    using System.Collections.Generic;

    public class ServerRoutingTable
    {
        public Dictionary<HttpRequestMethod, Dictionary<string, Func<IHttpRequest, IHttpResponse>>> Routes { get; }

        public ServerRoutingTable()
        {
            this.Routes = new Dictionary<HttpRequestMethod, Dictionary<string, Func<IHttpRequest, IHttpResponse>>>
            {
                [HttpRequestMethod.Get] = new Dictionary<string, Func<IHttpRequest, IHttpResponse>>(),
                [HttpRequestMethod.Post] = new Dictionary<string, Func<IHttpRequest, IHttpResponse>>(),
                [HttpRequestMethod.Put] = new Dictionary<string, Func<IHttpRequest, IHttpResponse>>(),
                [HttpRequestMethod.Delete] = new Dictionary<string, Func<IHttpRequest, IHttpResponse>>()
            };
        }
    }
}