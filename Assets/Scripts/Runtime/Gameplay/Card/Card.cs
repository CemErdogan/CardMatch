using UnityEngine;
using DG.Tweening;
using NaughtyAttributes;

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

    [Button]
    public void Select()
    {
        DOTween.Sequence()
            .Append(context.DOScale(1.5f, CardConstants.CardAnimationDuration)
                .SetEase(Ease.OutBack))
            .Join(context.DORotate(CardConstants.OpenRotaion, CardConstants.CardAnimationDuration)
                .SetEase(Ease.OutSine))
            .SetId(context);
    }

    [Button]
    public void Deselect()
    {
        DOTween.Sequence()
            .Append(context.DOScale(1f, CardConstants.CardAnimationDuration)
                .SetEase(Ease.InBack))
            .Join(context.DORotate(CardConstants.CloseRotaion, CardConstants.CardAnimationDuration)
                .SetEase(Ease.InSine))
            .SetId(context);
    }

    [Button]
    public void DelectWrong()
    {
        DOTween.Sequence()
            .AppendInterval(CardConstants.CardAnimationDuration * 2)
            .AppendCallback(()=> 
            {
                //todo: add sound
            })
            .Append(context.DOScale(1, CardConstants.CardAnimationDuration)
                .SetEase(Ease.InBack)) 
            .Join(context.DOShakeRotation(CardConstants.CardAnimationDuration, 30, 30, 35)
                .SetEase(Ease.InOutQuad))
            .Append(context.DORotate(CardConstants.CloseRotaion, CardConstants.CardAnimationDuration)
                .SetEase(Ease.InBack))
            .SetId(context);
    }

    void Close()
    {
        transform.DORotate(CardConstants.CloseRotaion, CardConstants.CardDelayDuration)
            .SetEase(Ease.OutBack)
            .SetDelay(1f);
    }
}
