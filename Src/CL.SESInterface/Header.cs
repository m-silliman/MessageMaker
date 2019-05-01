using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CL.SESInterface
{
    public class Header
    {
        public Header()
        {
            this.CreateTime = DateTime.UtcNow;
            this.HostName = Environment.MachineName;
            this.Id = Guid.NewGuid().ToString();
            this.Acknowledgement = AcknowledgementEnum.None;
        }

        public Header(string name)
        {
            this.Name = name;

            this.CreateTime = DateTime.UtcNow;
            this.HostName = Environment.MachineName;
            this.Id = Guid.NewGuid().ToString();
            this.Acknowledgement = AcknowledgementEnum.None;
        }

        public string Id { get; set; }

        public string Name { get; set; }
        public string HostName { get; set; }
        public DateTime CreateTime { get; set; }
        public AcknowledgementEnum Acknowledgement { get; set; }
    }
}
