using Keigo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KeigoChan.Services
{
    public class WordDataStore
    {

        List<Word> words;

        public WordDataStore()
        {
            words = new List<Word>();
            var mockItems = new List<Word>
        {
            new Word { JapaneseWord = "iimasu", HumbleEnding = "Iiiiimassuuu", RespectfulEnding = "iiiiimasu" },
            new Word { JapaneseWord = "tabemasu", HumbleEnding = "tabemasuuu", RespectfulEnding = "tabemasuuuuu" },

        };
        }

        public Word GetWord(string word)
        {
            return words.FirstOrDefault(s => s.JapaneseWord == word);
        }

    }
}
