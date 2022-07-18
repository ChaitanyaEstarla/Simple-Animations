using System.Collections;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class ChatOnAnim : MonoBehaviour
{
    public Image firstBar;
    public Image secondBar;
    public Image thirdBar;

    [SerializeField]
    private float animationDuration;
    private float delayTime;

    private void Start()
    {
        StartCoroutine(ChatOnAnimation());
    }

    private IEnumerator ChatOnAnimation()
    {
        delayTime = animationDuration / 2;
        firstBar.DOFillAmount(0.5f, animationDuration).From(1f).SetEase(Ease.Linear).SetLoops(-1, LoopType.Yoyo);
        secondBar.DOFillAmount(0.5f, animationDuration).From(1f).SetDelay(delayTime).SetEase(Ease.Linear).SetLoops(-1, LoopType.Yoyo);
        thirdBar.DOFillAmount(0.5f, animationDuration).From(1f).SetDelay(delayTime).SetEase(Ease.Linear).SetLoops(-1, LoopType.Yoyo);
        yield return null;
    }
    
    private void OnDestroy()
    {
        StopAllCoroutines();
    }

    private void OnDisable()
    {
        StopAllCoroutines();
    }
}