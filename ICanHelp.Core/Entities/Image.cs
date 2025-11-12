using ICanHelp.Core.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICanHelp.Core.Entities
{
    public class Image
    {
        public Id Id { get; set; }
        public StringObject FileName{ get; set; }
        public StringObject FileExtension{ get; set; }
        public StringObject FilePath{ get; set; }
    }
}
