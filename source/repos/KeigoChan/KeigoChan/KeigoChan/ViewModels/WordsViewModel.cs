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
        public string RespectfulEnding
        {
            get => _respectfulEnding;
            set => SetProperty(ref _respectfulEnding, value);
        }
        public string HumbleEnding
        {
            get => _humbleEnding;
            set => SetProperty(ref _humbleEnding, value);
        }
        private string _respectfulEnding;
        private string _humbleEnding;
        

        public WordsViewModel()
        {
            CompletedCommand = new Command(OnCompleted);            
        }

        private void OnCompleted()
        {
            IGetWord wordCheck = new WordDataStore();
            RespectfulEnding = wordCheck.GetWord(CompletedWord).RespectfulEnding;
            HumbleEnding = wordCheck.GetWord(CompletedWord).HumbleEnding;
        }
    }
}
