using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AnyVocab.Models;

namespace AnyVocab.Services
{
    public class TranslationStorageService
    {
        private readonly string packDirectory;

        public TranslationStorageService(string packDirectory = "../../../Data/")
        {
            this.packDirectory = packDirectory;
        }

        public VocabPack? ReadTranslationsFromFile(string packName)
        {
            try
            {
                string filePath = $"{packDirectory}{packName}.csv";
                string[] lines = File.ReadAllLines(filePath);
                VocabPack pack = new(packName);

                foreach (string line in lines)
                {
                    string[] parts = line.Split(';');
                    string word = parts[0].Trim();
                    string translation = parts[1].Trim();
                    VocabItem vocab = new(word, translation);
                    pack.AddVocabItem(vocab);
                }
                return pack;
            }
            catch (IOException e)
            {
                Console.WriteLine("Error reading file: " + e.Message);
                return null;
            }
        }

        public void StorePackToFile(VocabPack pack)
        {
            var packNames = getPackNames();
            for (int i = 1; packNames.Contains(pack.Name); i++)
            {
                pack.Name = pack.Name.Replace($" {i - 1}", "");
                pack.Name += $" {i}";
            }
            string packPath = $"{packDirectory}{pack.Name}.csv";
            using (StreamWriter writer = new (packPath))
            {
                pack.GetVocabulary().ForEach(vocab => writer.WriteLine($"{vocab.Word};{vocab.Translation}"));
            }
        }

        public IEnumerable<string?> getPackNames()
        {
            if (!Directory.Exists(packDirectory))
            {
                Directory.CreateDirectory(packDirectory);
            }
            return Directory.GetFiles(packDirectory).Select(Path.GetFileNameWithoutExtension).ToList();
        }
    }
}
