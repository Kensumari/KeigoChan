using System;
using System.Collections.Generic;
using System.Text;
using Keigo.Models;

namespace KeigoChan.Services
{
    public interface IGetWord
    {
        Word GetWord(string word);
        IEnumerable<string> GetFirstWords();
    }
}
