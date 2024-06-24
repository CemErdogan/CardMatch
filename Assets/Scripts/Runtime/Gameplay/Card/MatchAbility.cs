using System;
using UnityEngine;
using System.Collections.Generic;

public class MatchAbility : MonoBehaviour
{
    private Card _currentCard;
    List<Card> _selectedCards = new();
    
    void OnEnable()
    {
        TouchEvents.OnCardTapped += CardTapped_Callback;
        TouchEvents.OnEmptyTapped += EmptyTapped_Callback;
    }

    void OnDisable()
    {
        TouchEvents.OnCardTapped -= CardTapped_Callback;
        TouchEvents.OnEmptyTapped -= EmptyTapped_Callback;
    }

    void TryMatch()
    {
        if (_selectedCards.Count != 2)
        {
            return;
        }

        if (IsSelectedCardsSame())
        {
            // correct match
        }
        else
        {
            foreach (var card in _selectedCards)
            {
                card.Deselect();
            }
        }

        _selectedCards.Clear();
    }

    bool IsSelectedCardsSame()
    {
        return _selectedCards[0].ID == _selectedCards[1].ID;
    }

    private void CardTapped_Callback(Card card)
    {
        _currentCard = card;
        _currentCard.Select();
    }

    private void EmptyTapped_Callback()
    {
        if (_currentCard == null)
        {
            return;
        }

        _currentCard.Deselect();
        _currentCard = null;
    }
}
