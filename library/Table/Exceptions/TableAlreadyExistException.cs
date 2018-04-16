using System;
using System.Runtime.Serialization;

namespace library.Table.Exceptions
{
    [Serializable]
    internal class TableAlreadyExistException : Exception
    {

        public TableAlreadyExistException(ITable table) : base($"Table {table.Name.Long} already exists.  Not possible to add duplicate.")
        {
        }


    }
}