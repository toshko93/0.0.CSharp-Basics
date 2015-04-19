// Write a program that generates and prints all possible cards from a standard deck of 52 cards (without the jokers).
// The cards should be printed using the classical notation (like 5♠, A♥, 9♣ and K♦). The card faces should start from 2 to A.
// Print each card face in its four possible suits: clubs, diamonds, hearts and spades. Use 2 nested for-loops and a switch-case statement.
using System;

class AllCardsPrint
{
    enum CardValue : byte {Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King, Ace}
    enum CardSign : byte {spades, hearts, diamonds, clubs}
    static void Main()
    {
        foreach (string sign in Enum.GetNames(typeof(CardValue)))
        {
            foreach (string value in Enum.GetNames(typeof(CardSign)))
            {
                Console.WriteLine(sign + " of " + value);
            }
        }
    }
}