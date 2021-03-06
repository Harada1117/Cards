using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Deck : MonoBehaviour
{



    /// <summary>
    /// 昇順のDeckをゲットする
    /// </summary>
    public static List<Card> GetDeck()
    {
        var deck = new List<Card>();

        for (int i = 0; i < 52; i++)
        {
            deck.Add(new Card(Card.CardSuitJudge(i), Card.CardNumberJudge(i)));
        }
        return deck;
    }




    ///<summary>
    ///カードをDeckの中から取得する
    ///</summary>
    public static Card GetCard(List<Card> deck)
    {
        Card card = deck.First();
        deck.RemoveAt(0);
        return card;
    }
}