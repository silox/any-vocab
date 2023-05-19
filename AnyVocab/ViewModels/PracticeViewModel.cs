using AnyVocab.Models;
using AnyVocab.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Controls;

namespace AnyVocab.ViewModels
{
    public class PracticeViewModel
    {
        private VocabPack pack;
        private HashSet<VocabItem> guessed;
        private HashSet<VocabItem> pending;
        private HashSet<VocabItem> failed;
        public VocabItem? CurrentVocab { get; set; }
        private TranslationStorageService translationStorageService;


        public PracticeViewModel(VocabPack pack, TranslationStorageService translationStorageService)
        {
            this.pack = pack;
            this.translationStorageService = translationStorageService;
            guessed = new HashSet<VocabItem>();
            failed = new HashSet<VocabItem>();
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

        public void dumpIncorrectVocab(ComboBox comboBox)
        {
            var pack = new VocabPack($"{this.pack.Name}_hard");
            foreach (VocabItem failedVocab in failed)
            {
                pack.AddVocabItem(failedVocab);
            }
            translationStorageService.StorePackToFile(pack);
            comboBox.ItemsSource = translationStorageService.getPackNames();
        }

        public void AddGuessed(VocabItem vocab)
        {
            guessed.Add(vocab);
        }

        public void addFailed(VocabItem vocab)
        {
            failed.Add(vocab);
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

        public int GetIncorrectCount()
        {
            return failed.Count;
        }
    }
}
