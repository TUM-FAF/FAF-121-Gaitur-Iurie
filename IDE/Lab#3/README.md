## Mobile Applications Development
  - **Eclipse**

### Prerequisites:
  - IDEs: Eclipse
  - Languages:Java
  - Technologies and Frameworks:Android SDK

### Mandatory Tasks:
  - Study design guidlines for any mobile OS ([Android](https://developer.android.com/design/index.html), [iOS](https://developer.apple.com/library/ios/documentation/userexperience/conceptual/MobileHIG/index.html), [Windows Mobile](http://dev.windowsphone.com/en-us/design))
  - Create a mobile app and launch it on emulator/simulator. Your app should have at least 3 element (ex. button, textarea, statusbar...) and one action (ex. clicking on a button will trigger a popup)

### Tasks With Points:
  -Consume an API and display its data in application. You may use this API (requires registration) (2pt) 
  -Install your application on a mobile phone. It should have somewhere your full name (on main screen, in settings...)       (2pt) 
  -Create 3 different views (ex. one with a list of some element, one with some settings and one with application             description) (2pt) 
  -Debug an application. At some point you'll have bugs (ex. null pointer exception). Set breakpoints and/or watchers.          Find out buggy variables. (1pt) 
  -Use a hardware device for testing and debugging (1pt) 
  -Create a screen cast describing you application functionality. Use both video and audio. Mute screencasts does not         count (1pt)
  -Create a responsive layout (1pt)
###Additional Tasks:
  -Used an ORM for storing task – Sugar (1 pt)
  -User shared preference (1 pt)


#
## Screenshots and Video

1. Inside the emulator.

    ![Screenshot1](https://raw.githubusercontent.com/TUM-FAF/FAF-121-Gaitur-Iurie/master/IDE/Lab%233/screen_2.png)
    
    ![Screenshot1](https://raw.githubusercontent.com/TUM-FAF/FAF-121-Gaitur-Iurie/master/IDE/Lab%233/screen_3.png)
    
    ![Screenshot1](https://raw.githubusercontent.com/TUM-FAF/FAF-121-Gaitur-Iurie/master/IDE/Lab%233/screen_4.png)
    
    ![Screenshot1](https://raw.githubusercontent.com/TUM-FAF/FAF-121-Gaitur-Iurie/master/IDE/Lab%233/screen_6.png)
    

2. Screen cast (the microphone is not one of the goodest so my voice is heard very low)
  
  [Screen Cast describing my application functionality](https://www.youtube.com/watch?v=5Mkt4vSZzGo)


## Development
 
When I first saw the condition of this laboratory, first that came to mind was to make a to do list. Yes, a simple to do list. I started from creating packages for different layers, then I went to models. I knew that I have to store items somewhere so I started to write sql code in strings, but it was boring and it could took a lot of time so I searched for an ORM for sqLite
Then I found Sugar, it was very easy and in a short time I was able to develop mapping for two entities: task and category.
After that I started to do views, from the start I wanted them to contain more features but then I saw that it’s not very user experience that’s why I left only the most necessary features like progress, category and importance. 
Also I developed adapters for List items and CRUD operations. The thing that I liked the most was to get some data from internet by GET and to show them in the application. It was possible by KimonoLabs which is very good in situation when you need some GET data for your app.
Also I used shared preference in order know if it’s first time when user open this application so that will add default category only once.
At the end I want to say that I learned some new tricks that I didn’t knew before.
So, thanks for such a great lab, really .

