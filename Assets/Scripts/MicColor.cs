using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class MicColor : MonoBehaviour
{
    public Image mic;
    private void Start()
    {
        mic.DOColor(Color.red, 0.5f);
        this.Wait(1f, () =>
        {
            mic.DOColor(Color.white, 0.5f);
        });
    }
}
