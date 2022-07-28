using System;
using System.Collections.Generic;

#nullable disable

namespace dotnetCoreExample.Models
{
    public partial class HibernateSequence1
    {
        public string SequenceName { get; set; }
        public long? NextVal { get; set; }
    }
}
