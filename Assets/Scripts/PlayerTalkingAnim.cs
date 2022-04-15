using System.Collections;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class PlayerTalkingAnim : MonoBehaviour
{
    public GameObject micBg;
    
    private void Start()
    {
        StartCoroutine(TalkWave());
    }

    private IEnumerator TalkWave()
    {
        var count = 0;
        while (count < 3)
        {
            micBg.GetComponent<Image>().DOFade(0, 0.3f).From(0.5f);
            micBg.transform.DOScale(1.2f, 0.3f);
            yield return new WaitForSeconds(0.3f);
            micBg.GetComponent<Image>().DOFade(0.5f, 0.3f).From(0);
            micBg.transform.DOScale(1f, 0.3f);
            count++;
        }
    }
}
