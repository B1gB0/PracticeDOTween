using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class TextChanger : MonoBehaviour
{
    [SerializeField] private Text _text1;
    [SerializeField] private Text _text2;
    [SerializeField] private Text _text3;
    [SerializeField] private float _duration;

    private int _loops = -1;
    private string _newText1 = "Замена текста";
    private string _newText2 = " дополнение к  тексту";
    private string _newText3 = "Взлом текста!!!";

    private void Start()
    {
        _text1.DOText(_newText1, _duration).SetEase(Ease.Linear).SetLoops(_loops, LoopType.Yoyo);
        _text2.DOText(_newText2, _duration).SetRelative().SetEase(Ease.Linear).SetLoops(_loops, LoopType.Yoyo);
        _text3.DOText(_newText3, _duration, true, ScrambleMode.All).SetEase(Ease.Linear).SetLoops(_loops, LoopType.Yoyo);
        _text3.DOColor(Color.red, _duration).SetEase(Ease.Linear).SetLoops(_loops, LoopType.Yoyo);
    }
}
