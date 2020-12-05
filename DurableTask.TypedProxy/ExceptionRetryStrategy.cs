﻿using System;

namespace DurableTask.TypedProxy
{
    public static class ExceptionRetryStrategy<TException> where TException : Exception
    {
        public static bool Handle(Exception exception)
        {
            return exception.InnerException is TException;
        }
    }
}
