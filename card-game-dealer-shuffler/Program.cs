using System;
using System.Text;
using System.Threading.Tasks;

namespace card_game_dealer_shuffler
{
  partial class Program
  {
    static void Main(string[] args)
    {
      PokerDeckModel pokerDeck = new PokerDeckModel(); // Replace with BlackjackDeckModel to deal Blackjack
      var hand = pokerDeck.DealCards();                
      foreach (var card in hand)
      {
        Console.WriteLine($"{card.Value} of {card.Suit}");
      }
      Console.ReadLine();
    }
  }
}
