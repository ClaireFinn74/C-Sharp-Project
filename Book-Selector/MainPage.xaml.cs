using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Book_Selector.ViewModel;
using Windows.ApplicationModel;
using Windows.Data.Json;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Book_Selector
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        //public static List<myBooks> books = new List<myBooks>();
        public MainPage()
        {
            this.InitializeComponent();
            ViewNames = new ViewModel.NameViewModel();
        }

        public NameViewModel ViewNames { get; private set; }

        private void btnGoToRandom_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(RandomBookGenerator));
        }


        // <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The Parameter
        /// property is typically used to configure the page.</param>

        //protected override async void OnNavigatedTo(NavigationEventArgs e)
        //{
        //    await LoadLocalData();

        //   ` GridViewBooks.ItemsSource = books;

        //}

    }
}
