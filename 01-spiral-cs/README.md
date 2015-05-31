# Draw a spiral using ASCII characters

The problem is to draw a spiral using ASCII characters (presumably in a console window).

I chose to solve this one using C# and basic trig. The program gets the size of the grid to use, calculates a spiral shape by using sin, cos, and a continuously increasing `r`, plots that to a grid, and then prints the grid.

The grid used is a wrapper around a 2d array, with indexing safety - you can assign/read from indexes that don't exist without throwing an exception. This was key to keeping the spiral algorithm simple.