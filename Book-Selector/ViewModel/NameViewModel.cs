using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace Book_Selector.ViewModel
{
    public class NameViewModel : NotificationBase
    {
        Model.Books Names;

        public NameViewModel()
        {
            Model.Books test = new Model.Books();

            foreach (var book in test.Names)
            {
                var np = new BookViewModel(book);
                _book.Add(np);
            }
        }


        ObservableCollection<BookViewModel> _book
               = new ObservableCollection<BookViewModel>();

        public ObservableCollection<BookViewModel> book
        {
            get { return _book; }
            set { SetProperty(ref _book, value); }
        }

        int _SelectedIndex;
        public int SelectedIndex
        {
            get { return _SelectedIndex; }
            set
            {
                if (SetProperty(ref _SelectedIndex, value))
                { RaisePropertyChanged(nameof(SelectedBook)); }
            }
        }

        public BookViewModel SelectedBook
        {
                get { return (_SelectedIndex >= 0) ? _book[_SelectedIndex] : null; }
            } 
        }
    }
