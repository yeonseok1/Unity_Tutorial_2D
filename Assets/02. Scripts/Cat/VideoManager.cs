using UnityEngine;
using UnityEngine.Video;


namespace Cat
{
    public class VideoManager : MonoBehaviour
    {
        public GameObject videoPanel;

        public VideoPlayer vPlayer;
        public VideoClip[] vClips;

        private void Start()
        {
            vPlayer = GetComponent<VideoPlayer>();
        }

        public void VideoPlay(bool isHappy)
        {
            videoPanel.SetActive(true);

            var _clip = isHappy ? vClips[0] : vClips[1];
            vPlayer.clip = _clip;
            vPlayer.Play();
        }
    }
}
