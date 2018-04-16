namespace library.Table.Exceptions
{
    public class UnknownTableException : System.Exception
    {
        public UnknownTableException(string tablename) : base($"Unknown table {tablename}")
        {

        }
    }
}