using UnityEngine;
using DG.Tweening;

public class Card : MonoBehaviour
{
    [SerializeField] private Transform context;
    public int ID { get; private set; }

    public void Prepare(int id)
    {
        ID = id;
        Close();
    }

    private void Start()
    {
        Close();
    }

    public void Select()
    {
        transform.DORotate(CardConstants.OpenRotaion, 1f);
    }

    public void Deselect()
    {
        transform.DORotate(CardConstants.CloseRotaion, 1f);
    }

    void Close()
    {
        Debug.Log("Close");
        transform.DORotate(CardConstants.CloseRotaion, 1f)
            .SetEase(Ease.OutBack)
            .SetDelay(1f);
    }
}
