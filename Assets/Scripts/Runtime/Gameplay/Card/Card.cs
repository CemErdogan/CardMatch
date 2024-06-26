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

    private void OnDestroy()
    {
        DOTween.Kill(context);
    }

    public void Select()
    {
        DOTween.Sequence()
            .Append(context.DOScale(1.5f, CardConstants.CardAnimationDuration)
                .SetEase(Ease.OutBack))
            .Join(context.DORotate(CardConstants.OpenRotaion, CardConstants.CardAnimationDuration)
                .SetEase(Ease.OutSine))
            .SetId(context);
    }

    public void Deselect()
    {
        DOTween.Sequence()
            .Append(context.DOScale(1f, CardConstants.CardAnimationDuration)
                .SetEase(Ease.InBack))
            .Join(context.DORotate(CardConstants.CloseRotaion, CardConstants.CardAnimationDuration)
                .SetEase(Ease.InSine))
            .SetId(context);
    }

    void Close()
    {
        transform.DORotate(CardConstants.CloseRotaion, CardConstants.CardDelayDuration)
            .SetEase(Ease.OutBack)
            .SetDelay(1f);
    }
}
