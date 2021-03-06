﻿namespace SIS.Http.Responses.Contracts
{
    using SIS.Http.Enums;
    using SIS.Http.Headers;
    using SIS.Http.Headers.Contracts;

    public interface IHttpResponse
    {
        HttpResponseStatusCode StatusCode { get; set; }
        IHttpHeaderCollection Headers { get; }
        byte[] Content { get; set; }
        void AddHeader(HttpHeader header);
        byte[] GetBytes();
    }
}