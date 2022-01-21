using System;
using System.Runtime.Serialization;

namespace QuanLyNhaHangPizza_GUI.BUS_Pizza
{
    [Serializable]
    internal class DbUPdateException : Exception
    {
        public DbUPdateException()
        {
        }

        public DbUPdateException(string message) : base(message)
        {
        }

        public DbUPdateException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected DbUPdateException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}