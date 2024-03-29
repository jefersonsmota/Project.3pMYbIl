﻿using System;

namespace project.domain.Exceptions
{
    [Serializable]
    public abstract class HandlerException : Exception
    {
        public int HttpStatusCode { get; private set; }

        protected HandlerException(int httpStatusCode) { this.HttpStatusCode = httpStatusCode; }

        protected HandlerException(string message, int httpStatusCode) : base(message)
        {
            this.HttpStatusCode = httpStatusCode;
        }

        protected HandlerException(string message, Exception innerException, int httpStatusCode) : base(message, innerException)
        {
            this.HttpStatusCode = httpStatusCode;
        }

    }

    public class ValidationException : HandlerException
    {
        public ValidationException(string message = "", Exception innerException = null) : base(message, innerException, 400)
        {

        }
    }
}
