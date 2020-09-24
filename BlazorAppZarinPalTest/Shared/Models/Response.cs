using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorAppZarinPalTest.Shared.Models
{
    public class Response
    {
        #region CTOR
        public Response()
        {

        }

        public Response(int success, string message)
        {
            Success = success;
            Message = message;
        }
        #endregion

        #region Property
        public int Success { get; set; }
        public string Message { get; set; }
        #endregion

        #region Relation

        #endregion

        #region Calc

        #endregion
    }
}
