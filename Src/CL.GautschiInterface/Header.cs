using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CL.GautschiInterface
{
    public class Header
    {
        public Header()
        {
            Id = Guid.NewGuid().ToString();
            HostName = Environment.MachineName;
            CreateTime = DateTime.UtcNow;
            Acknowledgement = AcknowledgementEnum.None;
        }

        public Header(string name)
        {
            Id = Guid.NewGuid().ToString();
            HostName = Environment.MachineName;
            CreateTime = DateTime.UtcNow;
            Acknowledgement = AcknowledgementEnum.None;

            Name = name;
        }

        public string Id { get; set; }

        public string Name { get; set; }
        public string HostName { get; set; }
        public DateTime CreateTime { get; set; }
        public AcknowledgementEnum Acknowledgement { get; set; }
    }
}
