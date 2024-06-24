using UnityEngine;

public class CardManager : MonoBehaviour
{
    [SerializeField] CardFactory cardFactory;
    [SerializeField] LevelData levelData;
    Card[,] _cards;

    private void Awake()
    {
        PrepareCards();
    }

    void PrepareCards()
    {
        for(int x = 0; x <= levelData.amount.x; x++)
        {
            for (int y = 0; y <= levelData.amount.y; y++)
            {
                cardFactory.CreateCard(GetWorldPosition(x, y, levelData.cellSize));
            }
        }
    }

    Vector3 GetWorldPosition(int x, int y, float cellSize)
    {
        return new Vector3 (x, y, 0) * cellSize;
    }
}
