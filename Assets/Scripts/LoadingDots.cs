using System.Collections;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class LoadingDots : MonoBehaviour
{ 
    public Transform destination;
    public Transform startPosition;

    private Image circle;
    private Vector3 originalPos;
    
    [Header("Movement")]
    public float moveAnimationDuration = 1f;
    public float moveDelay = 0f;

    [Header("Fade")] 
    public float fadeAnimationDuration;
    public float fadeDelay;

    private float m_MoveAnimationDuration; 
    private float m_FadeAnimationDuration; 
    private float m_FadeDelay;
    private float m_MoveDelay; 

    private void OnEnable()
    {
        originalPos = startPosition.position;
        transform.position = originalPos;
        
        m_MoveAnimationDuration = moveAnimationDuration;
        m_FadeAnimationDuration = fadeAnimationDuration;
        m_FadeDelay = fadeDelay;
        m_MoveDelay = moveDelay;
        
        originalPos = transform.position;
        circle = transform.GetComponent<Image>();
        StartCoroutine(MoveDotToPosition());
        StartCoroutine(FadeImage());
    }

    private IEnumerator MoveDotToPosition()
    {
        yield return new WaitForSeconds(m_MoveDelay);
        circle.DOFade(1, 0.05f);
        m_MoveDelay = 0;
        transform.DOMoveX(destination.position.x, m_MoveAnimationDuration);
        StartCoroutine(ResetAnimation(m_MoveAnimationDuration));
    }

    private IEnumerator ResetAnimation(float duration)
    {
        yield return new WaitForSeconds(duration);
        transform.position = originalPos;
        StartCoroutine(FadeImage());
        StartCoroutine(MoveDotToPosition());
    }

    private IEnumerator FadeImage()
    {
        yield return new WaitForSeconds(m_FadeDelay);
        m_FadeDelay = 0.5f;
        circle.DOFade(0, m_FadeAnimationDuration);
    }

    private void OnDisable()
    {
        StopAllCoroutines();
    }
}
