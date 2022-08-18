using card_game_dealer_shuffler.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace card_game_dealer_shuffler
{
  partial class Program
  {
    public abstract class DeckModel
    {
      protected List<PlayingCardModel> fullDeck = new List<PlayingCardModel>();
      protected List<PlayingCardModel> drawPile = new List<PlayingCardModel>();
      protected List<PlayingCardModel> discardPile = new List<PlayingCardModel>();
      protected void CreateDeck()
      {
        for (int suit = 0; suit < 4; suit++)
        {
          for (int value = 0; value < 13; value++)
          {
            fullDeck.Add(new PlayingCardModel { Suit = (CardSuit)suit, Value = (CardValue)value });
          }
        }
      }
      public virtual void ShuffleDeck()
      {
        var rnd = new Random();
        drawPile = fullDeck.OrderBy(x => rnd.Next()).ToList();
      }
      public abstract List<PlayingCardModel> DealCards();
      protected virtual PlayingCardModel DrawOneCard()
      {
        PlayingCardModel output = drawPile.Take(1).First();
        drawPile.Remove(output);
        return output;
      }
    }
  }
}
