using System.Text;

namespace library.Table
{
    public class TextRowData : IRowData
    {
        private string _text;

        public TextRowData(string text)
        {
            _text=text;
        }
        public byte[] Raw => Encoding.UTF8.GetBytes(_text);
    }
}