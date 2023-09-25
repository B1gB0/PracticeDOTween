using UnityEngine;
using DG.Tweening;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _duration;

    private Vector3 _targetPosition;
    private float _direction = 5f;
    private int _loops = -1;

    private void Start()
    {
        SetDirection();
        Move();
    }

    private void Move()
    {
        transform.DOMove(_targetPosition, _duration).SetEase(Ease.Linear).SetLoops(_loops, LoopType.Yoyo);
    }

    private void SetDirection()
    {
        _targetPosition = transform.position;
        _targetPosition.z = _direction;
    }
}
