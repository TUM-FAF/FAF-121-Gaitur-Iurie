Laboratory work nr.1
====================
Title
-------------------

Window. Window handling. Basic window’s form elements.

Introduction
-------------------
Main purpose of this laboratoy work:

•Study winapi

•Understand event-driven programming

•Work with the events and the main concepts of the event-friven programming

Mandatory objectives
--------------------

•Create a windows application

•Choose a programming style what i'll follow

•Add 2 buttons to window: one with default styles, one with custom styles (size, background, text color, font family, font size)

•Add 2 text inputs to window: one with default styles, one with custom styles (size, background, text color, font family, font size)

•Add 2 text elements to window: one with default styles, one with custom styles (size, background, text color, font family, font size)

Objectives with points
----------------------

•Make elements to fit window on resize. (1 pt)

•Make elements to interact or change other elements. (2 pt)

•Change behavior of different window actions (at least 3). (1 pt)

•Write your own PSG. (1 pt)

Creation steps of the app:
-------------------------

I started from reading Petzold in order to undertand the main ideas of the Windows programming.I won't say that it didn't helped me, it just helped me to understand the main structure of a program and how events are called and how to declare them.

I used the template with the WinMain function that is the entry point in the program and create the main form of the app and the loop with GetMessages of the events.
After I worked with the WinProc function that process all the messages such as : WM_Create, WM_Command,WM_Close WM_Timer and others.
Also for interaction between objects I used methods for changing styles like SendMessage,GetClientRect,CreateFont,SetBkColor.


Features
---------------------------

My application consist of two edit boxes,one active and one inactive as a list.Also it has 4 output boxes with different styles and fonts.It also have two buttons, one with default style and one with custom style 



Functionality
----------------------------

• There is a timer that indicates how long remains till u have the possibility to introduce words.

• By clicking button Add, it will verify if such a word is in dictionary and if starts with the word from the output text what is above.

• By clicking the Close button, application close and show a message box with "Whyyyyyy :D" text.

• There is a text what score your letters by such an algorithm: difference between the letters of the word introduced by you and the have to contain part.

• When time is end, then the add button deactivates and lets you just to close the application.

• By clicking the X button, the main window moves to a random place of the screen.

• The window has a minimal and maximal size and also allows resizing.

• All the objects from the window react at any dimension changes.


