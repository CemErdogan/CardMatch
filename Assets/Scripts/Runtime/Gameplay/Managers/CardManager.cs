using UnityEngine;

public class CardManager : MonoBehaviour
{
    [SerializeField] CardFactory cardFactory;
    [SerializeField] LevelConfigurationSO levelDataSO;
    LevelData _currentLevelData;
    Card[,] _cards;

    private void Awake()
    {
        _currentLevelData = GetLevelData();
        PrepareCards();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            DataHandler.LevelIndex++;
        }
    }

    void PrepareCards()
    {
        for(int x = 0; x < _currentLevelData.amount.x; x++)
        {
            for (int y = 0; y < _currentLevelData.amount.y; y++)
            {
                cardFactory.CreateCard(GetWorldPosition(x, y, _currentLevelData.cellSize));
            }
        }
    }

    Vector3 GetWorldPosition(int x, int y, float cellSize)
    {
        return new Vector3 (x, y, 0) * cellSize;
    }

    LevelData GetLevelData()
    {
        return levelDataSO.levelData[DataHandler.LevelIndex % levelDataSO.levelData.Length];
    }
}
