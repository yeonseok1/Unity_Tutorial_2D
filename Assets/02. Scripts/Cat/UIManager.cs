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
                Debug.Log("�Է��� �ؽ�Ʈ ����");
            }
            else
            {
                playObj.SetActive(true);
                Debug.Log($"{nameTextUI.text} �Է�");
                nameTextUI.text = inputField.text;

                introUI.SetActive(false);

            }
        }
    }
}


