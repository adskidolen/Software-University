﻿namespace SIS.Http.Headers
{
    using SIS.Http.Common;
    using SIS.Http.Headers.Contracts;

    using System.Collections.Generic;

    public class HttpHeaderCollection : IHttpHeaderCollection
    {
        private readonly Dictionary<string, HttpHeader> headers;

        public HttpHeaderCollection()
        {
            this.headers = new Dictionary<string, HttpHeader>();
        }

        public void Add(HttpHeader header)
        {
            CoreValidator.ThrowIfNull(header, nameof(header));
            this.headers.Add(header.Key, header);
        }

        public bool ContainsHeader(string key)
        {
            CoreValidator.ThrowIfNull(key, nameof(key));
            return this.headers.ContainsKey(key);
        }

        public HttpHeader GetHeader(string key)
        {
            CoreValidator.ThrowIfNull(key, nameof(key));
            return this.headers.GetValueOrDefault(key, null);
        }

        public override string ToString()
        {
            return string.Join(GlobalConstants.HttpNewLine, this.headers.Values);
        }
    }
}