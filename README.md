# C-Sharp-Project

## App-Description:
__Launching__:

When the app is launched, a Splashscreen appears with a description of the app to keep the user busy while the screen loads.
[![launch.png](https://s17.postimg.org/x020cj5v3/launch.png)](https://postimg.org/image/3xnq9pjl7/)
__First Page__ :

When the app loads you are greeted with a 'library' of books all laid out in the 'MVVM' style. You can click on each title and see information such as *Title, Author, Genre, Description* and an *Image* of that particular book you've clicked on.
Within Visual Studio I included 58 images in the XAML code. These images are pictures of different books.
This information is *parsed* in using *JSON* and due to the large volume of information included within the text file being read in I had to include Async/await functionality to deal with the wait time involved to parse this information in.
I have included a *scrollviewer* so that the user can easily see all of the titles of the books I included.
[![runningpage1.png](https://s15.postimg.org/53fbpk35n/runningpage1.png)](https://postimg.org/image/tjxhk13w7/)
There is also a button that navigates the user to the next page where you will find the more fun element to the Book Selector:

__Second Page: *Random Book Generator:*__

On this page you will find a button that tells the user to double-click to get a random book suggestion. To do this, I included within the *xaml.cs*; a *randomizer array* that includes all 58 books. I then created an if/else statement for each book so that when the random array picks that book, the image for that particular book is displayed also.

*__Before User clicks the Random button:__*

[![FINAL.png](https://s12.postimg.org/ns6n8sqot/FINAL.png)](https://postimg.org/image/v85wulee1/)
*__After User clicks the Random button:__*

[![FINAL2.png](https://s16.postimg.org/5jshq3qr9/FINAL2.png)](https://postimg.org/image/ca8yzjdwx/)

## Authentication - Azure Active Directory:

Another function available to the user of my *Book_Selector* app is the ability to sign in with __Azure Active Directory__.
A button can be pressed and a pop-up will appear where the user can sign in with their Azure username and password and then that user will be cached and remembered for future use of the app.
[![authentication.png](https://s13.postimg.org/mm1n2i9p3/authentication.png)](https://postimg.org/image/vttvj7gr7/)


## Issues I overcame:

1. Now one problem I had was the fact that __each time__ the user clicks the Random button a book image will appear, resulting in all images appearing on top of one another. I handled this by making each of the 58 images visibility equal to "collapsed" so that they don't show up on the screen at all when you start the app and then when the user presses the Random button *only one* images's visibility is set to "visible".  This was handled within the if/else statements by setting the images' visibility property to visible only when that particular image is clicked.
2. Another problem I had was the fact that even though I set the image's visibility property to visible only when picked, the previous image still displayed when I pressed the 'Random' button again. I handled this by making the Random button's visibility property set to "Collapsed" once the Random button is picked the first time. Then, hidden behind the Random button, is a "Search again" button (which looks the exact same as the Random button; It has the same width, height, has the same caption and is in the exact same Margin as the Random button). Then, to click the Random button a second time, the user is actually clicking the hidden "Search Again" button which is set to hide all images on the page. This gets rid of the problem by clearing the screen. Then, the "Search Again" button sets it's own visibility to "Collapsed" and activates the Random button's visibility again which starts the array over. 

# References:
https://learnonline.gmit.ie/course/view.php?id=2542

https://msdn.microsoft.com/en-us/default.aspx

https://postimage.org/

http://stackoverflow.com/
