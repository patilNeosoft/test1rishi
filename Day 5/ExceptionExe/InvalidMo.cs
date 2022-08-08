using System.Runtime.Serialization;

namespace ExceptionExe
{
    [Serializable]
    internal class InvalidMo : Exception
    {
       
        public InvalidMo(string? message) : base(message)
        {
        }

       
    }
}