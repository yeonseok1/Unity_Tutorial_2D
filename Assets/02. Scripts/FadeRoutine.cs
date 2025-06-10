using System.Collections;
using UnityEngine;
using UnityEngine.UI;
public class FadeRoutine : MonoBehaviour
{
    public Image fadePanel;
    public bool isFadeOut = true;

    public float fadeTime = 3f;

    void Start()
    {
        // StartCoroutine(FadeRoutineA(fadeTime, isFadeOut));
    }

    public void OnFade(float _fadeTime, bool _isFadeOut, Color _fColor)
    {
        StartCoroutine(FadeRoutineA(_fadeTime, _isFadeOut, _fColor));
    }


    IEnumerator FadeRoutineA(float fTime, bool isFO, Color fColor)
    {
        float timer = 0f;
        float percent = 0f;
        float value = isFO ? 0 : 1;

        while (percent < 1f)
        {
            timer += Time.deltaTime;
            percent = timer / fTime;
            value = isFO ? percent : 1 - percent;

            fadePanel.color = new Color(fColor.r, fColor.g, fColor.b, value);
            yield return null;
        }
    }

    //IEnumerator Start()
    //{
    //    while (percent < 1f)
    //    {
    //        timer += Time.deltaTime;
    //        percent = timer / fadeTime;

    //        fadePanel.color = new Color(fadePanel.color.r, fadePanel.color.g, fadePanel.color.b, percent);
    //        yield return null;
    //    }

    //}
}
