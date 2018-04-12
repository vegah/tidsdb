namespace library.Table
{
    public class TableName
    {
        public TableName(string name)
        {
            // Dummy
            Short = name;
            Long = name;
        }
        // Add validation here
        public string Short {get;private set;}
        public string Long {get;private set;}
    }
}