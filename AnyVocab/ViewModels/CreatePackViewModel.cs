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
            pack = new VocabPack("New Pack");
        }

        public void AddVocab(string word, string translation)
        {
            pack.AddVocabItem(new VocabItem(word, translation));
        }

        public void StorePack()
        {
            TranslationStorageService storageService = new();
            storageService.StorePackToFile(pack);
        }
    }
}
