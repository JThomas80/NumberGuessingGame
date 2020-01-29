# NumberGuessingGame

Simple to project to refresh and expand on.
 
 A simple, straightforward tutorial taken from https://www.youtube.com/watch?v=GcFJjpMFJvI (Traversy Media) to refresh basic C# skills and serve as a basis for expanding on the basic idea of the program, also. While it was a basic tutorial, I did feel some foundational skills returning and came up with some ideas to improve on the basic random number guessing game. It did help to reinforce some basic skills such as function construction, program flow, such as checking input type before assigning it to a variable and different ways to display output to the console, EG ConsoleColor method for text and a new way to modify strings with variables [Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);].
 
I also attempted to improve the program slightly and make it more to my liking instead of copying the code character for character from the video. To that end, I ended up digging into some documentation to research specific details like how to alter the console title window with variables [Console.Title = string.Format("{0}'s Number Guessing Game", appAuthor);] and whether the arguments for the random range function are inclusive or exclusive (turns out, it's both, inclusive for the low end and exclusive for the high end.) I also altered the comments and feedback messages to the user to be clearer and more to my personal taste.

I also have a todo list of features to incorporate into the program soon to flesh it out a bit and extend it beyond the basic random number game that most everyone has probably built immediately following "Hello World!".

TODO:
-Let the user choose the range for both high and low numbers, will need logic to verify the low number is actually lower than high number and reassign if necessary.

- Session statistics tracking, such as number of guesses per game, average number of guesses to win and other possible interesting stats that may appear as the program develops.

-Overall game tracking, similar to a high score table on an arcade machine, probably through an external text file. May look into encrypting the text file, also, either through a simple scheme or actual strong encryption of some sort.
 
 -Refactoring code to better fit OOP principles and for cleaner design overall.
