using TMPro;
using UnityEngine;

namespace Cat
{
    public class GameManager : MonoBehaviour
    {
        public SoundManager soundManager;

        public TextMeshProUGUI playTimeUI;
        public TextMeshProUGUI scoreUI;

        private float timer;
        public static int score;  // ����� ���� ����
        public static bool isPlay;

        void Start()
        {
            soundManager.SetBGMSound("Intro");
        }

        void Update()
        {
            if (!isPlay) return;

            timer += Time.deltaTime;

            playTimeUI.text = $"�÷��� �ð� : {timer:F1}��";
            scoreUI.text = $"X {score}";
        }
    }
}
