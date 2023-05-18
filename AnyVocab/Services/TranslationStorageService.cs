using AnyVocab.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnyVocab.Services
{
    public class VocabularyTranslator
    {
        private List<VocabItem> vocabulary;
        public VocabularyTranslator(string filePath)
        {
            vocabulary = new List<VocabItem>();
            ReadTranslationsFromFile(filePath);
        }

        private void ReadTranslationsFromFile(string filePath)
        {
            try
            {
                string[] lines = File.ReadAllLines(filePath);

                foreach (string line in lines)
                {
                    string[] parts = line.Split(';');
                    string word = parts[0].Trim();
                    string translation = parts[1].Trim();
                    VocabItem vocab = new (word, translation);
                    vocabulary.Add(vocab);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Error reading file: " + e.Message);
            }
        }

        public void DumpTranslations()
        {
            foreach (var vocab in vocabulary)
            {
                Console.WriteLine($"{vocab.Word};{vocab.Translation}");
            }
        }
    }
}
