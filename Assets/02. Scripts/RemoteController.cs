using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class RemoteController : MonoBehaviour
{
    [Header("����ũ�� ������Ʈ")]
    public GameObject videoScreen;
    public Button[] buttonUI;
    public VideoClip[] clips;   // ���� ���� �迭
    private VideoPlayer videoPlayer;

    public int currClipIndex = 0;  // ���� ���� �ε���

    // public bool isOn = false;
    public bool isMute = false;


    private void Awake()
    {
        videoPlayer = videoScreen.GetComponent<VideoPlayer>();
        videoPlayer.clip = clips[0];  // Default ���� ����
    }
    private void Start()
    {
        buttonUI[0].onClick.AddListener(OnScreenPower);
        buttonUI[1].onClick.AddListener(OnMute);
        buttonUI[2].onClick.AddListener(OnPrevChannel);
        buttonUI[3].onClick.AddListener(OnNextChannel);
    }

    public void OnScreenPower()
    {
        videoScreen.SetActive(!videoScreen.activeSelf);

        //isOn = !isOn;
        //videoScreen.SetActive(isOn);

        /*
        if (!isOn)
        {
            videoScreen.SetActive(true);
            isOn = true;
        }
        else
        {
            videoScreen.SetActive(false);
            isOn = false;
        }*/
    }

    public void OnMute()
    {
        isMute = !isMute;
        videoPlayer.SetDirectAudioMute(0, isMute);
    }

    public void OnNextChannel()
    {
        currClipIndex++;
        if (currClipIndex > clips.Length - 1)
            currClipIndex = 0;

        videoPlayer.clip = clips[currClipIndex];
        videoPlayer.Play();
    }

    public void OnPrevChannel()
    {
        currClipIndex--;
        if (currClipIndex < 0)
            currClipIndex = clips.Length - 1;

        videoPlayer.clip = clips[currClipIndex];
        videoPlayer.Play();
    }
}
