using UnityEngine;

public class CardFactory : MonoBehaviour
{
    [SerializeField] Card cardPrefab;
    [SerializeField] Transform cardParent;

    public Card CreateCard()
    {
        var card = Instantiate(cardPrefab, cardParent);
        return card;
    }
}
