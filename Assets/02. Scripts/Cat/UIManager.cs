using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Cat
{
    public class UIManager : MonoBehaviour
    {
        public SoundManager soundManager;

        public GameObject playObj;
        public GameObject introUI;
        public GameObject playUI;

        public TMP_InputField inputField;
        public TextMeshProUGUI nameTextUI;

        public Button startButton;

        private void Awake()
        {
            playObj.SetActive(false);
            playUI.SetActive(false);
            introUI.SetActive(true);

        }

        void Start()
        {
            startButton.onClick.AddListener(OnStartButton);
        }

        public void OnStartButton()
        {
            bool _isNoText = inputField.text == "";

            if (_isNoText)
            {
                Debug.Log("�Է��� �ؽ�Ʈ ����");
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
    }
}


