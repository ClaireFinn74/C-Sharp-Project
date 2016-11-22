using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel;
using Windows.Data.Json;
using Windows.Storage;
using Data;

namespace Book_Selector.Model
{
    class Books
    {
        public List<myBooks> Names { get; set; }
        public static List<myBooks> gBookList = new List<myBooks>();
        public String BookName { get; set; }

        public Books()
        {
            LoadData();
            Names = gBookList;
        }

        public static async Task LoadData()
        {
            await LoadLocalData();
        }

        public static async Task LoadLocalData()
        {
            var file = await Package.Current.InstalledLocation.GetFileAsync("Data\\myBooks.txt");
            var result = await FileIO.ReadTextAsync(file);

            var ZBookList = JsonArray.Parse(result);
            CreateBooksList(ZBookList);
        }

        private static void CreateBooksList(JsonArray ZBookList)
        {
            foreach (var item in ZBookList)
            {
                var oneBook = item.GetObject();
                myBooks nBook = new myBooks();

                foreach (var key in oneBook.Keys)
                {
                    IJsonValue value;
                    if (!oneBook.TryGetValue(key, out value))
                        continue;

                    switch (key)
                    {
                        case "Name":
                            nBook.Name = value.GetString();
                            break;
                        case "Genre":
                            nBook.Genre = value.GetString();
                            break;
                        case "Author":
                            nBook.Author = value.GetString();
                            break;
                        case "Description":
                            nBook.Description = value.GetString();
                            break;
                        case "Image":
                            nBook.Image = value.GetString();
                            break;
                    } // end switch
                } // end foreach(var key in oneBook.Keys )
                gBookList.Add(nBook);
            } // end foreach (var item in jBookList)
        }
    }
}