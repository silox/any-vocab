using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnyVocab.Models
{
    internal class VocabPack
    {
        private List<VocabItem> vocabulary;
        public string Name { get; set; }
        public string FilePath { get; set; }

        public VocabPack(string name, string filePath)
        {
            Name = name;
            FilePath = filePath;
            vocabulary = new List<VocabItem>();
        }

        public List<VocabItem> GetVocabulary() { return vocabulary; }

        public void AddVocabItem(VocabItem vocab)
        {
            vocabulary.Add(vocab);
        }
    }
}
