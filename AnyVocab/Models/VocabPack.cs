using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnyVocab.Models
{
    public class VocabPack
    {
        private List<VocabItem> vocabulary;
        public string Name { get; set; }

        public VocabPack(string name = "")
        {
            Name = name;
            vocabulary = new List<VocabItem>();
        }

        public List<VocabItem> GetVocabulary() { return vocabulary; }

        public int GetVocabCount() { return vocabulary.Count; }

        public void AddVocabItem(VocabItem vocab)
        {
            vocabulary.Add(vocab);
        }
    }
}
