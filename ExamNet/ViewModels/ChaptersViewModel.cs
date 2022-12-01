using GalaSoft.MvvmLight.CommandWpf;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ExamNet.ViewModels
{
	public class ChaptersViewModel : INotifyPropertyChanged
	{
		private ObservableCollection<Chapter> chapters;
		public ObservableCollection<Chapter> Chapters
		{
			get { return chapters; }
			set
			{
				chapters = value;
				OnProperyChanged("Chapters");
			}
		}

        private Chapter _selectedChapter;

        public Chapter SelectedChapter
        {
            get { return _selectedChapter; }
            set { _selectedChapter = value; }
        }


        public ChaptersViewModel()
		{
			Chapters = new ObservableCollection<Chapter>(new WitcherModel().Chapters);
		}

        private RelayCommand _showCommand;

        public RelayCommand ShowCommand
        {
            get { return _showCommand ?? (_showCommand = new RelayCommand(ShowCharacters)); }
        }


        private void ShowCharacters()
        {
            if (SelectedChapter == null)
                return;
			Cards cards = new Cards(SelectedChapter.ID);
			cards.ShowDialog();
        }		
		


        public event PropertyChangedEventHandler PropertyChanged;

		public void OnProperyChanged([CallerMemberName]string prop ="")
		{
			if(PropertyChanged != null)
				PropertyChanged(this, new PropertyChangedEventArgs(prop));
		}
	}
}
