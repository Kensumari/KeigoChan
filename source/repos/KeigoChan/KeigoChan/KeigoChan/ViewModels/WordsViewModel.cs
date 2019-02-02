using Keigo.Models;
using KeigoChan.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace KeigoChan.ViewModels
{
    public class WordsViewModel : BaseViewModel
    {
        public ICommand CompletedCommand { get; set; }
        public ICommand EnteringCommand { get; set; }
        public IEnumerable<string> WordList { get; set; }
        public string InputWord { get; set; }
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
        IGetWord wordCheck = new WordDataStore();

        public WordsViewModel()
        {
            EnteringCommand = new Command(OnEntering);
            CompletedCommand = new Command(OnCompleted);            
        }

        private void OnCompleted()
        {
            try
            {
                RespectfulEnding = wordCheck.GetWord(InputWord).RespectfulEnding;
                HumbleEnding = wordCheck.GetWord(InputWord).HumbleEnding;
            }
            catch (Exception)
            {
            }
        }

        private void OnEntering()
        {
                WordList = wordCheck.GetFirstWords();
                WordList.Where(s => s.Contains(InputWord));
        }
    }
}
