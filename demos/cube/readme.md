[← Back](../../index.html)

# 3D Cube - Readme
================

This code dates back to 1994, originally from my Computer Science programming classes. It was created in standard ANSI "C" language, using Borland C compiler (or Turbo C++) and the "graphics.h" library. The Borland Graphics Interface, also known as BGI, was a graphics library bundled with several Borland compilers for the DOS operating systems since 1987. [Reference](https://en.wikipedia.org/wiki/Borland_Graphics_Interface)  
If my memory serves me right, the goal of this project was to learn about C/C++ language syntax, data structures, arrays, vectors, matrices (sprinkled with some Linear Algebra, 2D and 3D projections). For the lack of better things to do added with some nostalgia I decided to modernize this code to be able to run in current 64 bit machines, and even though you can still run the original code in Turbo C++ using DosBox, I decided to try a more modern and cross-platform approach. I made some testes with gcc and some BGI ports but all require a lot of tools and libraries to be installed... Bummer! so, considering the fact that every machine today has an Internet browser installed and capable of running Javascript, why not explore the HTML5 canvas features?  

**Disclaimer:**  
This code is for learning and fun purposes and it does not follow any design pattern, clean code or any enterpise level standards. Just have fun and enjoy!

* * *

Here are the original 1994 files (no modifications, same code with minor changes):

*   [KUBO1.CPP](./original/KUBO1.CPP)
*   [KUBO2.CPP](./original/KUBO2.CPP)
*   [Project information](./projeto.md) (PT-BR) the same as translated below
*   [EGAVGA.BGI](./original/EGAVGA.BGI) (need this file for graphics)

In the The next project, building on the previous one, the idea was to write a word with 3D letters, using pointers and dynamic memory allocation with malloc() function - and possibly getting some "null pointer exceptions" ;-) :

*   [JONATAS.CPP](./original/JONATAS.CPP)

Moving futher, the next program "GRAVA.CPP" will initialize all 26 letters and save to the "LETRAS.DAT" file.  
The other program "LETRAS.CPP" will read a word from the user input, load the letters from the "LETRAS.DAT" file, dynamic allocate memory and display it:

*   [GRAVA.CPP](./original/GRAVA.CPP)
*   [LETRAS.DAT](./original/LETRAS.DAT)
*   [LETRAS.CPP](./original/LETRAS.CPP)

**Cube 3D - Project:**

Elaborate an object-oriented program for the manipulation of a cube in 3 (three) dimensions (X, Y and Z axes).  
The cube is colored on the screen and can be enlarged or reduced (scale), rotated (rotation) or moved in space (translation).

The Cube object is initialized with its initial coordinates (8 points in space that will form the edges) and each point in the format P(x, y, z)

The Object must have methods for showing and erasing (drawing) the cube in space.  
Methods to increase and reduce the object (cable), move in space and rotate on any axis.

The representation must be made on the screen (an environment in 2 dimensions x and y) so in the representation there must be the conversion of a three-dimensional system (space) to a two-dimensional system (screen or plane).  
The entire representation was elaborated in the Cartesian coordinate system (x,y,z).

The whole process of object manipulation is done through the use of matrices.

\- Preliminary considerations  
\- Geometric transformations

Every design is composed of primitives (dots) whose parameters are coordinated in relation to the origin of a Cartesian system.  
Its transformation is obtained by transforming all the coordinates that are parameters of these primitives.

Fundamental types of transformation:  
\- scale  
\- translation  
\- rotation around origin  

**Scale**

It is called transformation in scale the enlargement or reduction of a figure.  
The transformation in scale is obtained by multiplying all the coordinates that define the design (points) by non-zero scale factors.  
In the two-dimensional case, these factors are:  
horizontal scale factor that multiplies the coordinates referring to the X axis of the Cartesian system and the vetical scale factor that multiplies the coordinates referring to the cartesian system Y axis.

Calling the horizontal and vertical scale factors of Ex and Ey, the coordinates (x',y') obtained by the transformation of scale of the coordinated (x,y) are worth:

x' = Ex \* x  
y' = Ey \* y

A scale factor greater than 1 causes an image magnification in the direction of the axis affected by the factor.  
A scale factor between 0 and 1 causes a reduction.  
A negative factor causes a mirroring of the image in relation to the axis not affected by this factor.

When the two factors Ex and Ey are equal, the figure obtained is similar to the original, that is, it does not suffer distortion.  
When the scale factors are different, distorted figures are obtained from the original.

Note that when a scale transfomation is applied to a drawing, not only its size changes but also the distance from its points to the origin of the coordinate system, because the point (0.0) is the center of the scale.  
To scale in relation to a point other than the origin, a combination of translation transformations and scale must be made.

**Translation**

The movement of a figure to another position in the coordinate system is called a translation, so that all points in the image are displaced from the same distance to their previous position.

The translation transformation is obitated by adding to all the coordinates that define the drawing, the translation constants.  
In the two-dimensional case, there are two constants: one referring to the displacement parallel to the X axis and another referring to the displacement parallel to the Y axis.  
By calling these constants Tx and Ty, the coordinates (x',y') obtained by the translation of the coordinate point (x,y) are valid:

x' = Tx + x  
y' = Ty + y

**Rotation at Around the origin**

It is called rotation around the origin to the movement of a figure to another position, so that all points of the image maintain the same distance from the origin they had before the transformation.  
To obtain a rotation around any point, a combination of translation and rotation transformations around the origin must be made.

The only parameter of rotation transformation is the angle ϴ, which indicates the value of angular displacement counterclockwise.

The coordinates (x',y') obtained by rotating the coordinate point (x,y) of an angle ϴ around the origin are valid:

x' = x \* cos ϴ - y \* sen ϴ  
y' = y \* cos ϴ + y \* sen ϴ
