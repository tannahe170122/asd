using System;
using System.Collections.Generic;
using System.IO; // Importing the System.IO namespace for file handling

// This is the beginning of the Exercise29 class
public class Exercise29
{
    // This is the main method where the program execution starts
    public static void Main()
    {
        // Creating a FileInfo object representing a file at the specified path
        FileInfo f = new FileInfo("C:\\Users\\admin\\Documents\\1. MÔN HỌC\\8. PRN\\Assignment 1\\29\\abc.txt");

        // Displaying the size of the file in bytes using FileInfo's Length property
        Console.WriteLine("\nSize of a file: " + f.Length.ToString());
    }
}
