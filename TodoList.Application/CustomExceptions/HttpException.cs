﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoList.Application.CustomExceptions
{
    public class HttpException:Exception
    {
        public HttpException(String Message, Exception InnerException):base(Message,InnerException)
        {
            
        }
        public HttpException(String Message):base(Message)
        {
            
        }
    }
}
