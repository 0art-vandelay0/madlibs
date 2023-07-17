// namespace Madlibs.Models
// {
//     public class MadlibVariable
//     {
//         public string Noun { get; set; }
//         public string Verb { get; set; }
//         public string Adjective { get; set; }
//         public string Adverb { get; set; }
//     }
// }

namespace Madlibs.Models
{
    public class MadlibVariable
    {
        public string[] Nouns { get; set; }
        public string[] Verbs { get; set; }
        public string[] Adjectives { get; set; }
        public string[] Adverbs { get; set; }
    }
}