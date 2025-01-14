# Number Guessing Game

A simple console-based number guessing game written in C#.

## How to Play

1. The game will ask if you want to continue playing (Y/N)
2. Enter a number between 1-100
3. The computer will randomly guess a number
4. You'll get feedback if your number is:
   - Equal to the computer's guess (You score a point!)
   - Greater than the computer's guess
   - Less than the computer's guess
   - Outside the valid range (You lose a point!)

## Features

- Score tracking system
- Random number generation
- Input validation
- User-friendly interface

## Technical Details

- Written in C#
- Uses .NET Console Application
- Implements Random class for number generation
- Includes basic error handling

## Known Bugs

1. The Y/N check is case-sensitive (only uppercase 'Y' works)
2. String comparison uses `==` instead of `.Equals()` for Y/N check
3. No input validation for non-numeric entries when guessing numbers
4. The game continues even with invalid number inputs
5. The Random_number method should follow C# naming conventions (should be RandomNumber)
6. The game loop logic is reversed - it exits when user inputs 'Y' instead of 'N'

## Areas for Improvement

1. Add proper input validation
2. Make Y/N check case-insensitive
3. Implement proper error handling for non-numeric inputs
4. Fix the game loop logic
5. Follow C# naming conventions
6. Add maximum attempts per game

