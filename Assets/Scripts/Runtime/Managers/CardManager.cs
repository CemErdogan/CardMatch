using UnityEngine;

public class CardManager : MonoBehaviour
{
    [SerializeField] CardFactory cardFactory;
    [SerializeField] float cellSize;
    Card[,] _cards;

    private void Awake()
    {
        PrepareCards();
    }

    void PrepareCards()
    {
        for(int x = 0; x <= 5; x++)
        {
            for (int y = 0; y <= 5; y++)
            {
                cardFactory.CreateCard(GetWorldPosition(x, y, cellSize));
            }
        }
    }

    Vector3 GetWorldPosition(int x, int y, float cellSize)
    {
        return new Vector3 (x, y, 0) * cellSize;
    }
}
