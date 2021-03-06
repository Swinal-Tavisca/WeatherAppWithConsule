
using System;
using System.Net;
using Tavisca.Platform.Common.Models;
using System.Runtime.Serialization;

namespace Tavisca.Common.Plugins.Configuration
{
    [Serializable]
    public partial class ConfigurationException : BaseApplicationException
    {
        public ConfigurationException(string code, string message, HttpStatusCode httpStatusCode) : base(code, message, httpStatusCode) { }

        public ConfigurationException(SerializationInfo info,StreamingContext context) : base(info,context) {}

		public ConfigurationException(ErrorInfo info) : base(info.Code, info.Message, info.HttpStatusCode) { }

		public ConfigurationException(string message, string code, Exception inner) : base(message, code, inner){ }
    }
}
