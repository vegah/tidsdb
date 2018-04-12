namespace library.Table
{
    public class Table : ITable
    {
        private readonly ITableReader _reader;
        private readonly ITableWriter _writer;
        private readonly TableName _name;

        public Table(ITableReader reader, ITableWriter writer, TableName name)
        {
            _writer = writer;
            _reader = reader;
            _name = name;
        }

        public TableName Name => _name;
    }
}