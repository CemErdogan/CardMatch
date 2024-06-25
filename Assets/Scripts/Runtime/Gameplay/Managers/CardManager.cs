using UnityEngine;

public class CardManager : MonoBehaviour
{
    [SerializeField] CardFactory cardFactory;
    Card[,] _cards;

    private void Awake()
    {
        LevelEvents.OnLevelDataSet += PrepareCards;
    }

    private void OnDestroy()
    {
        LevelEvents.OnLevelDataSet -= PrepareCards;
    }

    void PrepareCards(LevelData levelData)
    {
        _cards = new Card[levelData.amount.x, levelData.amount.y];

        for (int x = 0; x < levelData.amount.x; x++)
        {
            for (int y = 0; y < levelData.amount.y; y++)
            {
                _cards[x, y] = cardFactory.CreateCard(GetWorldPosition(x, y, levelData.cellSize));
            }
        }

        CardEvents.OnCardsPrepared?.Invoke(_cards);
    }

    Vector3 GetWorldPosition(int x, int y, float cellSize)
    {
        return new Vector3 (x, y, 0) * cellSize;
    }
}
