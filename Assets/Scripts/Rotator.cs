using UnityEngine;
using DG.Tweening;

public class Rotator : MonoBehaviour
{
    [SerializeField] private float _duration;

    private Vector3 _direction = new Vector3(0f, 180f, 0f);
    private int _loops = -1;

    private void Start()
    {
        transform.DORotate(_direction, _duration).SetEase(Ease.Linear).SetLoops(_loops, LoopType.Restart);
    }
}
