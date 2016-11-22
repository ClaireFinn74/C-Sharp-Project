using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media.Imaging;

namespace Book_Selector.ViewModel
{
    public class BookViewModel : NotificationBase<Data.myBooks>
    {
        public BookViewModel(Data.myBooks book = null) : base(book) { }

        public String Name
        {
            get { return This.Name; }
            set { SetProperty(This.Name, value, () => This.Name = value); }
        }
        public String Genre
        {
            get { return This.Genre; }
            set { SetProperty(This.Genre, value, () => This.Genre = value); }
        }
        public String Author
        {
            get { return This.Author; }
            set { SetProperty(This.Author, value, () => This.Author = value); }
        }
        public String Description
        {
            get { return This.Description; }
            set { SetProperty(This.Description, value, () => This.Description = value); }
        }

        public String Image
        {
            get { return This.Image; }
            set { SetProperty(This.Image, value, () => This.Image = value); }
        }
    }
}
