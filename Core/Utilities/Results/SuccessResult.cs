using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class SuccessResult:Result
    {
        public SuccessResult(string message) : base(true, message) //"base" ana result class'ını çağırır
        {

        }

        public SuccessResult():base(true)
        {

        }
    }
}
