using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Cat
{
    public class UIManager : MonoBehaviour
    {
        public SoundManager soundManager;
        public GameObject gamemManager;

        public GameObject playObj;
        public GameObject introUI;
        public GameObject playUI;
        public GameObject videoPanel;

        public TMP_InputField inputField;
        public TextMeshProUGUI nameTextUI;

        public Button startButton;
        public Button restartButton;

        private void Awake()
        {
            playObj.SetActive(false);
            playUI.SetActive(false);
            introUI.SetActive(true);

        }

        void Start()
        {
            startButton.onClick.AddListener(OnStartButton);
            restartButton.onClick.AddListener(OnRestartButton);
        }

        public void OnStartButton()
        {
            bool _isNoText = inputField.text == "";

            if (_isNoText)
            {
                Debug.Log("입력한 텍스트 없음");
            }
            else
            {
                nameTextUI.text = inputField.text;
                soundManager.SetBGMSound("Play");

                GameManager.isPlay = true;

                playObj.SetActive(true);
                playUI.SetActive(true);
                introUI.SetActive(false);

            }
        }

        public void OnRestartButton()
        {

            GameManager.ResetScore();
            playObj.SetActive(true);
            videoPanel.SetActive(false);
        }
    }
}


