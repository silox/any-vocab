using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AnyVocab.Models;
using AnyVocab.Services;

namespace AnyVocab.ViewModels
{
    class CreatePackViewModel
    {
        private VocabPack pack;

        public CreatePackViewModel()
        {
            pack = new VocabPack();
        }

        public void AddVocab(string word, string translation)
        {
            pack.AddVocabItem(new VocabItem(word, translation));
        }

        public void StorePack()
        {
            TranslationStorageService storageService = new();
            if (pack.Name == "")
            {
                pack.Name = "New Pack";
            }
            storageService.StorePackToFile(pack);
        }

        public void UpdatePackName(string name)
        {
            pack.Name = name;
        }

        public IEnumerable<string?> getPackNames()
        {
            TranslationStorageService storageService = new();
            return storageService.getPackNames();
        }
    }
}
