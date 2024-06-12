using System;
using UnityEngine;

public class CardManager : MonoBehaviour
{
    private Card _currentCard;
    
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
