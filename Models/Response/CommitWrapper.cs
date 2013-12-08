using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Octokit
{
    public class CommitWrapper
    {
        public Commit Commit { get; set; }

        public IEnumerable<Files> Files { get; set; }
    }
}
