using System.Collections;
using DG.Tweening;
using UnityEngine;
using Image = UnityEngine.UI.Image;

public class MicComms : MonoBehaviour
{
    public Image[] bars;
    
    public RectTransform secondBar;
    public RectTransform thirdBar;
    public RectTransform fourthBar;

    private void Start()
    {
        StartCoroutine(ChangeColor());
        StartCoroutine(ScaleUpBars());
    }
    
    private IEnumerator ChangeColor()
    {
        for (var i=0; i<bars.Length;i++)
        {
            bars[i].DOColor(Color.white, 1f);
        }

        yield return new WaitForSeconds(1f);
        
        for (var i=0; i<bars.Length;i++)
        {
            bars[i].DOColor(Color.grey, 1f);
        }
    }

    private IEnumerator ScaleUpBars()
    {
        var count = 0;
        const float timeLimit = 4;
        while (count < timeLimit)
        {
            secondBar.DOScaleY(3, 0.5f/timeLimit);
            fourthBar.DOScaleY(3, 0.5f/timeLimit);
            thirdBar.DOScaleY(5, 0.5f/timeLimit);
            yield return new WaitForSeconds(0.5f/timeLimit);
        
            secondBar.DOScaleY(1, 0.5f/timeLimit);
            fourthBar.DOScaleY(1, 0.5f/timeLimit);
            thirdBar.DOScaleY(3, 0.5f/timeLimit);
            yield return new WaitForSeconds(0.5f/timeLimit);
            
            count++;
        }
        thirdBar.DOScaleY(1, 0.5f/timeLimit);
    }
}