using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Octokit
{
    public class Payload
    {
        public int PushId { get; set; }
        public int Size { get; set; }

        public int DistinctSize { get; set; }
        public string Ref { get; set; }

        public string Head { get; set; }

        public string Before { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public ICollection<Commit> Commits { get; set; }

    }
}




