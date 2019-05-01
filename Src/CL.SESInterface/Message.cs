using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace CL.SESInterface
{
    public class Message
    {
        public Message() { }

        public Message(string name)
        {
            Header = new Header(name);
        }

        [JsonProperty(Order = -2)]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        public Header Header { get; set; }
                   
    }
}
