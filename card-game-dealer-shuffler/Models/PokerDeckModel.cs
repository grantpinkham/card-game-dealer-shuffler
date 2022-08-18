using card_game_dealer_shuffler.Models;
using System.Collections.Generic;

namespace card_game_dealer_shuffler
{
  partial class Program
  {
    public class PokerDeckModel : DeckModel
    {
      public PokerDeckModel()
      {
        CreateDeck();
        ShuffleDeck();
      }
      public override List<PlayingCardModel> DealCards()
      {
        List<PlayingCardModel> output = new List<PlayingCardModel>();
        for (int i = 0; i < 5; i++)
        {
          output.Add(DrawOneCard());
        }
        return output;
      }
      public List<PlayingCardModel> RequestCards(List<PlayingCardModel> cardsToDiscard)
      {
        List<PlayingCardModel> output = new List<PlayingCardModel>();
        foreach (var card in cardsToDiscard)
        {
          output.Add(DrawOneCard());
          discardPile.Add(card);
        }
        return output;
      }
    }
  }
}
