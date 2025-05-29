using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Pinball : MonoBehaviour
{
    public PinballManager pinballManager;

    void OnCollisionEnter2D(Collision2D other)
    {
        int _score = 0;

        if (other.gameObject.CompareTag("Untagged") == false)
        {
            switch (other.gameObject.tag)
            {
                case "Score10":
                    _score = 10;
                    break;
                case "Score30":
                    _score = 30;
                    break;
                case "Score50":
                    _score = 50;
                    break;
            }

            pinballManager.totalScore += _score;
            Debug.Log($"{_score}점 획득");
        }


    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("GameOver"))
        {
            Debug.Log($"게임 종료 : 현재점수 {pinballManager.totalScore}");
        }
    }

}
