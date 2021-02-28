using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        
        //get > read only'dir ancak cunstructor içinde "set" edilebilir.

        public Result(bool success, string message):this (success) //Aşağıdaki success ile birlikte çalışır.
        {
            Message = message;
        }
        public Result(bool success)
        {            
            Success = success;
        }

        public bool Success { get; }

        public string Message { get; }
    }
}
