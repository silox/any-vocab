using AnyVocab.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AnyVocab.ViewModels
{
    public class PracticeViewModel
    {
        private VocabPack pack;
        private HashSet<VocabItem> guessed;
        private HashSet<VocabItem> pending;
        public VocabItem? CurrentVocab { get; set; }

        public PracticeViewModel(VocabPack pack)
        {
            this.pack = pack;
            guessed = new HashSet<VocabItem>();
            pending = new HashSet<VocabItem>(pack.GetVocabulary());
        }
  
        public VocabItem? GetNextVocab()
        {
            if (pending.Count == 0)
            {
                return null;
            }

            Random rand = new();
            int index = rand.Next(pending.Count);
            VocabItem nextVocab = pending.ElementAt(index);
            pending.Remove(nextVocab);
            return nextVocab;
        }

        public void AddGuessed(VocabItem vocab)
        {
            guessed.Add(vocab);
        }

        public void returnPending(VocabItem vocab)
        {
            pending.Add(vocab);
        }

        public int GetTotalCount()
        {
            return pending.Count + guessed.Count;
        }

        public int GetGuessedCount()
        {
            return guessed.Count;
        }
    }
}
