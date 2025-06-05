using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Cat
{
    public class UIManager : MonoBehaviour
    {
        public GameObject playObj;
        public GameObject introUI;

        public TMP_InputField inputField;
        public TextMeshProUGUI nameTextUI;

        public Button startButton;

        void Start()
        {
            startButton.onClick.AddListener(OnStartButton);
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
                playObj.SetActive(true);
                Debug.Log($"{nameTextUI.text} 입력");
                nameTextUI.text = inputField.text;

                introUI.SetActive(false);

            }
        }
    }
}


