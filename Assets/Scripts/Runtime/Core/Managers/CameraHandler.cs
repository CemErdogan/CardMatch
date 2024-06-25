using UnityEngine;
using Cinemachine;

public class CameraHandler : MonoBehaviour
{
    [SerializeField] CinemachineVirtualCamera vCam;
    [SerializeField] CinemachineTargetGroup targetGroup;
    [SerializeField] float weight;

    private void Awake()
    {
        CardEvents.OnCardsPrepared += Prepare_Callback;
    }

    private void OnDestroy()
    {
        CardEvents.OnCardsPrepared -= Prepare_Callback;
    }

    void Prepare_Callback(Card[,] cards)
    {

    }
}
