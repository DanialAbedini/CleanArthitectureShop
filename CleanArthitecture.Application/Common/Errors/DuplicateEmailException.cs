﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CleanArthitecture.Application.Common.Errors
{
    public class ValidationErrors : Exception, IServiceException
    {
        public HttpStatusCode StatusCode => HttpStatusCode.Forbidden;

        public string ErrorMessage => "Email already Exist";
    }
}