using System;

namespace Orders.Classes.Exceptions
{
    public class WorkException : Exception
    {
        public WorkException() { }
        public WorkException(string message) : base(message) { }
        public WorkException(string message, Exception ex) : base(message, ex) { }
        // Конструктор для обработки сериализации типа
        protected WorkException(System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext contex)
            : base(info, contex)
        { }
    }
}