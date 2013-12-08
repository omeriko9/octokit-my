using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Octokit
{
    public class ContentFile
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "type")]
        public string type {get;set;}
        public string Encoding { get; set; }
        public int Size { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public string Content { get; set; }
        public string Sha { get; set; }
        public string Url { get; set; }
        public string GitUrl { get; set; }
        public string HtmlUrl { get; set; }
    }
}
