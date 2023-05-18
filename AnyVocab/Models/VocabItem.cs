using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fastenshtein;

namespace AnyVocab.Models
{
    class VocabItem
    {
        public int? Id { get; set; }
        public string Word { get; set; }
        public string Translation { get; set; }

        public VocabItem(string word, string translation)
        {
            Word = word;
            Translation = translation;
        }

        public VocabItem(int id, string word, string translation)
        {
            Id = id;
            Word = word;
            Translation = translation;
        }

        public override string ToString()
        {
            return $"{Word} - {Translation}";
        }

        public bool CheckTranslation(string currTrans)
        {
            return Levenshtein.Distance(Translation, currTrans) <= 1;
        }
    }
}
