namespace library.Table
{
    public class IntRowKey : IRowKey
    {
        private readonly int _no;

        public IntRowKey(int no) 
        {
            _no = no;
        }
        public string RowKeyAsString  => _no.ToString();
    }
}