using System.Runtime.Serialization;

namespace LorUClassRegistrationApp.Models
{
    [Serializable]
    internal class DeptNotFound : Exception
    {
        public DeptNotFound()
        {
        }

        public DeptNotFound(string? message) : base(message)
        {
        }

        public DeptNotFound(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected DeptNotFound(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}