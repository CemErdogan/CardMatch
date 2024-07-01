using UnityEngine;

public class CardManager : MonoBehaviour
{
    [SerializeField] CardLib cardLib;
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
        // card lib'ten random kartları al
        
        _cards = new Card[levelData.amount.x, levelData.amount.y];
        
        // random containera ekle (5 farklı akrt var ama 6 farklı karta ihtiyacımız vardı)
        
        // listeyi karıştır
        
        // cardları prepare
        

        CardEvents.OnCardsPrepared?.Invoke(_cards);
    }

    Vector3 GetWorldPosition(int x, int y, float cellSize)
    {
        return new Vector3 (x, y, 0) * cellSize;
    }
}
