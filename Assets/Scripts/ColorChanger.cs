using UnityEngine;
using DG.Tweening;

[RequireComponent(typeof(SpriteRenderer))]
public class ColorChanger : MonoBehaviour
{
    [SerializeField] private float _durationChangeColor;
    [SerializeField] private float _durationFade;

    private SpriteRenderer _spriteRenderer;
    private float _fade = 0f;
    private int _loops = -1;

    private void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _spriteRenderer.DOColor(Color.red, _durationChangeColor).SetEase(Ease.Linear).SetLoops(_loops, LoopType.Yoyo);
        _spriteRenderer.DOFade(_fade, _durationFade).SetEase(Ease.Linear).SetLoops(_loops, LoopType.Yoyo);
    }
}
