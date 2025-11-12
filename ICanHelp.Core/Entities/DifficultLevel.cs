using ICanHelp.Core.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICanHelp.Core.Entities
{
    public class DifficultLevel
    {
        public Id Id { get; set; }
        public StringObject DifficultLevelName { get; set; }

        public DifficultLevel(Id id, StringObject difficultLevelName)
        {
            Id = id;
            DifficultLevelName = difficultLevelName;
        }
    }
}
