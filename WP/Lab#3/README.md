# WP Laboratory Work #3

## Title

Basic of Working with Mouse. GDI Primitives. Bezier Curve

## Contents

  - Mouse
  - Device
  - GDI Primitives
    - Line
    - Curve
    - Plane
    - Bitmap Image
  - Bezier Curve


## Executed Tasks:
  - **Mandatory Tasks:**
    - Draw few lines of different colors and weights.
    - Draw a Bezier curve.
    - Draw few plane objects(ex. circle, square, pie, polygon, ) of different colors, weights, filled and not.
    - Draw 2 different objects using mouse.

  - **Tasks With Points:**
    - Add a switch(button, select list...) that will change mouse ability to draw objects(2 pt)
    - Draw a bezier curv using mouse (1pt)
    - Use mouse as an eraser of:
      - a fixed width (1pt)
      - a adjustable width (2pt)

  


## Screenshots

1. The application

    ![Screenshot1](https://raw.githubusercontent.com/TUM-FAF/FAF-121-Gaitur-Iurie/master/WP/Lab%233/Screenshot_1.png)



## Development
 
 It took me a looooot of time in order to do this laboratory work. But thanks to god, I was able to finish it.
It was one of the most tough laboratories that I written, because somehow it did not attracted me. Don’t know why . 
Now I will tell how I made this laboratory work. I started from reading about drawing lines and simple objects like rectangle and ellipse from Petzold and Google. I implemented this. Then I delimited the region where I can draw and where cannot. Next step was Bezier and eraser. Bezier was easy to implement , cause we need 3 points in order to draw it. So I stored data when Bezier tool is active and user click in the paint region, in array and when 3 times user click  we draw it.
But with eraser I had some conflicts, then after some time someone help me with implementing the eraser.
Then I had to put all this things with data, like border, filling colors. I saw at someone that delimited the tools in 2 group boxes, so I thought that it will be a great idea if I will delimit it too, because in this way is more user friendly. It took a lot of time with filling color, borders too.
Especially long, took to make the report :D. 
At the end I want to say that I understood how important is to draw things programmatically.
Maybe I will need these knowledge in the future.

 
