namespace YachtWorld.Core.Exceptions
{
    public class YachtRentingException : ApplicationException
    {
        public YachtRentingException()
        {

        }

        public YachtRentingException(string errorMessage)
            : base(errorMessage)
        {

        }
    }
}
