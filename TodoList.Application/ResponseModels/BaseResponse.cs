﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoList.Application.ResponseModels
{
    public class BaseResponse
    {
        public BaseResponse()
        {
            Success = true;
        }
        public bool Success { get; set; }
        public string Message { get; set; }
        public string InnerExceptionMessage { get; set; }
        public void SetException(Exception exception)
        {
            Success=false;
            Message=exception.Message;
        }


    }
}
