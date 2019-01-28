using Keigo.Models;
using KeigoChan.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace KeigoChan.ViewModels
{
    public class WordsViewModel : BaseViewModel
    {
        public ICommand CompletedCommand { get; set; }
        public string CompletedWord { get; set; }
        public string RespectfulEnding { get; set; }
        public string HumbleEnding { get; set; }

        public WordsViewModel()
        {
            CompletedCommand = new Command(OnCompleted);            
        }

        private void OnCompleted()
        {
            var wordCheck = new WordDataStore();
            RespectfulEnding = wordCheck.GetWord(CompletedWord).RespectfulEnding;
            HumbleEnding = wordCheck.GetWord(CompletedWord).HumbleEnding;
        }
    }
}
