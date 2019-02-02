using Keigo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KeigoChan.Services
{
    public class WordDataStore : IGetWord
    {

        List<Word> words;

        public WordDataStore()
        {
            words = new List<Word>
            {
                new Word { JapaneseWord = "iimasu", HumbleEnding = "Iiiiimassuuu", RespectfulEnding = "iiiiimasu" },
                new Word { JapaneseWord = "iimasen", HumbleEnding = "Iissuuu", RespectfulEnding = "iiisu" },
                new Word { JapaneseWord = "iimasssen", HumbleEnding = "Iissuuu", RespectfulEnding = "iiisu" },
                new Word { JapaneseWord = "iimas23en", HumbleEnding = "Iissuuu", RespectfulEnding = "iiisu" },
                new Word { JapaneseWord = "iimarsen", HumbleEnding = "Iissuuu", RespectfulEnding = "iiisu" },
                new Word { JapaneseWord = "iimassaen", HumbleEnding = "Iissuuu", RespectfulEnding = "iiisu" },
                new Word { JapaneseWord = "tabemasu", HumbleEnding = "tabemasuuu", RespectfulEnding = "tabemasuuuuu" },
            };
        }

        public Word GetWord(string word)
        {
                return words.FirstOrDefault(s => s.JapaneseWord == word);
        }

        public IEnumerable<string> GetFirstWords()
        {
            foreach (var item in words)
            {
                yield return item.JapaneseWord;
            }
        }
    }
}
