﻿using System;

namespace BDB.Common.Types
{
    public class BusinessException : Exception
    {
        public string Code { get; }

        public BusinessException()
        {
        }

        public BusinessException(string code)
        {
            Code = code;
        }

        public BusinessException(string message, params object[] args)
            : this(string.Empty, message, args)
        {
        }

        public BusinessException(string code, string message, params object[] args)
            : this(null, code, message, args)
        {
        }

        public BusinessException(Exception innerException, string message, params object[] args)
            : this(innerException, string.Empty, message, args)
        {
        }

        public BusinessException(Exception innerException, string code, string message, params object[] args)
            : base(string.Format(message, args), innerException)
        {
            Code = code;
        }
    }
}
