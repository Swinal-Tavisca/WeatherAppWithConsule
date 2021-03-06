
using System;
using System.Net;
using Tavisca.Platform.Common.Models;
using System.Runtime.Serialization;

namespace Tavisca.Common.Plugins.Configuration
{
    [Serializable]
    public partial class SerializationException : BaseApplicationException
    {
        public SerializationException(string code, string message, HttpStatusCode httpStatusCode) : base(code, message, httpStatusCode) { }

        public SerializationException(SerializationInfo info,StreamingContext context) : base(info,context) {}

		public SerializationException(ErrorInfo info) : base(info.Code, info.Message, info.HttpStatusCode) { }

		public SerializationException(string message, string code, Exception inner) : base(message, code, inner){ }
    }
}
