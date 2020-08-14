using System;
using System.Collections.Generic;
using System.Text;

namespace AdaptorDesignPattern
{
    public class XBankCardReaderAdapter : ICardReaderAdapter
    {
        public string ReadCardData()
        {
            var reader = new XBankPOSReader();
            return reader.ReadFromCard();
        }
    }
}
