
## Title

GUI Development

## Contents

  - IDEs:Visual Studio
  - Language: C#
  - Technologies and Frameworks: Forms

  It is 4102. Aliens invaded us. Luckily the world has some great engineers and you are one of them! Your'e working on an unbeatable weapon: Simulatron. Simulatron is an exact copy of alien ship but it has a secret: when the alien gets into ship the alien is traped and brought into human prison. Your task is very simple: you have to clone Simulatron's control panel. World depends on you

## Executed Tasks:
  - **Mandatory Tasks:**
    - Define 3 virtual tasks that you Simulatron is supposed to control.
    - Create a GUI application with 5 standard controls
  - **Tasks With Points:**
    -	Add 3 non-standard controls (2pt)
    -Make controls to interact. At least 3 interactions (1pt)
    -Create a custom control(not existent in IDE)(2pt)
    -Create a Reset button. On clicking this button all controls should go to their default state (1pt)
    -Set a breakpoint in your application and check variables values at that moment of time (1pt)
    -Set debug watches that will not stop your application from running but will allow you to check any application's               state(ex. if a function was called) (1pt)
    -Add a Unit test. For this you'll need to divide your source code in Controller and View (Business and Presentation           layer) (2pt)

  - **Additional Tasks:**
    - Fun effects and music.(1pt)
    - XML parsing
    - Using controls (1pt)
    - Quiz form create (1pt)



## Screenshots and Video

This is how application looks
    
![Screenshot1](https://raw.githubusercontent.com/TUM-FAF/FAF-121-Gaitur-Iurie/master/IDE/Lab%232/Screenshot_1.png)
![Screenshot2](https://raw.githubusercontent.com/TUM-FAF/FAF-121-Gaitur-Iurie/master/IDE/Lab%232/Screenshot_2.png)
![Screenshot3](https://raw.githubusercontent.com/TUM-FAF/FAF-121-Gaitur-Iurie/master/IDE/Lab%232/Screenshot_3.png)
![Screenshot4](https://raw.githubusercontent.com/TUM-FAF/FAF-121-Gaitur-Iurie/master/IDE/Lab%232/Screenshot_4.png)
![Screenshot5](https://raw.githubusercontent.com/TUM-FAF/FAF-121-Gaitur-Iurie/master/IDE/Lab%232/Screenshot_5.png)
Short video
  
  [How my Program works, Video](https://www.youtube.com/watch?v=mwS2vJE7GTc)



## Development
 
From the start I had great plans about this laboratory works, but because of lack of time I stopped on small tasks like making a quiz and a simple motivation letter in star wars theme.


Steps of creating project were: 
-Created the solution
    -Created projects for :
      -Views(contained forms and controls)
      -Tests(application tests)
      -Models(entity classes)
      -Custom control(button)
      
      
 At the beginning I had multi forms but then when I started the application I saw that it’s not cool, so I created controls and just added them in main form by some user actions like click.
Then I created an entity class for question from quiz and an xml file for storing the questions.
Then I created a custom button, it wasn’t a difficult task because on internet is a lot of resource about how to create a custom control.


 After that I written a test that was testing a function that return a list of questions.
And I tested if it will not return null, by this mean that the path to the file is correct.

  At the end I want to say that tasks and idea of the laboratory work were very interesting and also I would like to thank you for inventing such great labs.
