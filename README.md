# C-Sharp-Project

## App-Description:
`` Within Visual Studio I included 58 images in the XAML code. These images are pictures of different books. I also created a Random button so that when the user clicks this button a random book will appear. ``

`` Within the xaml.cs; I create a randomizer array that includes all 58 books. I then created an if/else statement for each book so that when the random array picks that book, the image for that particular book is displayed also. ``

`` Now one problem I had was the fact that __each time__ the user clicks the Random button a book image will appear, resulting in all images appearing on top of one another. I handled this by making each of the 58 images visibility equal to "collapsed" so that they don't show up on the screen at all when you start the app and then when the user presses the Random button *only one* images's visibility is set to "visible".  This was handled within the if/else statements by setting the images' visibility property to visible only when that particular image is clicked. ``

`` Another problem I had was the fact that even though I set the image's visibility property to visible only when picked, the previous image still displayed when I pressed the 'Random' button again. I handled this by making the Random button's visibility property set to "Collapsed" once the Random button is picked the first time. Then, hidden behind the Random button, is a "Search again" button (which looks the exact same as the Random button; It has the same width, height, has the same caption and is in the exact same Margin as the Random button). Then, to click the Random button a second time, the user is actually clicking the hidden "Search Again" button which is set to hide all images on the page. This gets rid of the problem by clearing the screen. Then, the "Search Again" button sets it's own visibility to "Collapsed" and activates the Random button's visibility again which starts the array over.`
