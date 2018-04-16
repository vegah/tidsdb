using System.Collections.Generic;
using library.Table.Exceptions;

namespace library.Table
{
    public class TableCollection
    {
        private Dictionary<string, ITable> _tables;

        public TableCollection()
        {
            _tables=new Dictionary<string, ITable>();
        } 

        public void Add(ITable table)
        {
            if (!_tables.ContainsKey(table.Name.Long))
                _tables.Add(table.Name.Long,table);
            else
                throw new TableAlreadyExistException(table);
        }

        public ITable GetByName(string name)
        {
            if (_tables.ContainsKey(name))
                return _tables[name];
            throw new UnknownTableException(name);
        }
    }
}