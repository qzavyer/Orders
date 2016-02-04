using System;

namespace Orders.Classes.Exceptions
{
    public class HandledException : Exception
    {
        public HandledException() { }
        public HandledException(string message) : base(message) { }
        public HandledException(string message, Exception ex) : base(message, ex)
        { }
        // ����������� ��� ��������� ������������ ����
        protected HandledException(System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext contex)
            : base(info, contex)
        { }
    }
}