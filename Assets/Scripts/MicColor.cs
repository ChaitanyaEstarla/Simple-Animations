using System.Collections;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class MicColor : MonoBehaviour
{
    public Image mic;
    private void Start()
    {
        StartCoroutine(ChangeColor());
    }

    private IEnumerator ChangeColor()
    {
        mic.DOColor(Color.red, 0.5f);
        yield return new WaitForSeconds(1f);
        mic.DOColor(Color.white, 0.5f);
    }
}
