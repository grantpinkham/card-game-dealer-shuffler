using card_game_dealer_shuffler.Models;
using System.Collections.Generic;

namespace card_game_dealer_shuffler
{
  partial class Program
  {
    public class BlackjackDeckModel : DeckModel
    {
      public BlackjackDeckModel()
      {
        CreateDeck();
        ShuffleDeck();
      }
      public override List<PlayingCardModel> DealCards()
      {
        List<PlayingCardModel> output = new List<PlayingCardModel>();
        for (int i = 0; i < 2; i++)
        {
          output.Add(DrawOneCard());
        }
        return output;
      }
      public PlayingCardModel RequestCard()
      {
        return DrawOneCard();
      }
    }
  }
}
