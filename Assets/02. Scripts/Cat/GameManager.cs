using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI playTimeUI;
    private float timer;

    void Start()
    {
        
    }

    void Update()
    {
        timer += Time.deltaTime;

        playTimeUI.text = $"�÷��� �ð� : {timer:F0}��";
    }
}
