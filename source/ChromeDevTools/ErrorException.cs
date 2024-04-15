using System;

namespace MasterDevs.ChromeDevTools
{
    public class ErrorException : Exception
    {
        public ErrorResponse Error { get; set; }
        public int Code { get; set; }
        public ErrorException(ErrorResponse err) : base(err.Error.Message)
        {
            Error = err;
            Code = err.Error.Code;
        }
    }
}
