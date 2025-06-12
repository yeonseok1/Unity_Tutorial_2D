using TMPro;
using UnityEngine;

namespace Cat
{
    public class GameManager : MonoBehaviour
    {
        public SoundManager soundManager;
        public GameObject UIManger;
        public GameObject playObj;

        public TextMeshProUGUI playTimeUI;
        public TextMeshProUGUI scoreUI;

        public static float timer;
        public static int score;  // 사과를 먹은 갯수
        public static bool isPlay;

        void Start()
        {
            soundManager.SetBGMSound("Intro");
        }

        void Update()
        {
            if (!isPlay) return;

            timer += Time.deltaTime;

            playTimeUI.text = $"플레이 시간 : {timer:F1}초";
            scoreUI.text = $"X {score}";
        }

        public static void ResetScore()
        {
            timer = 0;
            score = 0;
        }
    }
}
