using UnityEngine;
using DG.Tweening;

public class Scaler : MonoBehaviour
{
    [SerializeField] private float _duration;

    private Vector3 _maxScale = new Vector3(4f, 4f, 4f);
    private int _loops = -1;

    private void Start()
    {
        transform.DOScale(_maxScale, _duration).SetEase(Ease.Linear).SetLoops(_loops, LoopType.Yoyo);
    }
}
