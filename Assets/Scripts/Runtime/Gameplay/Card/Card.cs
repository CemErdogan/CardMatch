using UnityEngine;

public class Card : MonoBehaviour
{
    [SerializeField] private Transform context;
    public int ID { get; private set; }

    public void Prepare(int id)
    {
        ID = id;
        Close();
    }

    public void Select()
    {
        transform.eulerAngles = CardConstants.OpenRotaion;
    }

    public void Deselect()
    {
        transform.eulerAngles = CardConstants.CloseRotaion;
    }

    void Close()
    {
        transform.eulerAngles = CardConstants.CloseRotaion;
    }
}
