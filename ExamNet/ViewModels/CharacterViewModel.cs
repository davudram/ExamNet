using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ExamNet.ViewModels
{
    public class CharacterViewModel : INotifyCollectionChanged
    {
        private ObservableCollection<Character> character;

        public event NotifyCollectionChangedEventHandler CollectionChanged;

        public ObservableCollection<Character> Characters
        {
            get { return character; }
            set { character = value; }
        }

        public CharacterViewModel()
        {
            character = new ObservableCollection<Character>(new WitcherModel().Characters);
        }

        public CharacterViewModel(int chapterID)
        {
            character = new ObservableCollection<Character>(new WitcherModel().Characters.Where(x => x.Chapter_ID == chapterID));
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnProperyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
