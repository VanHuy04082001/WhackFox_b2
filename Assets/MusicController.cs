using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VanHuy
{
    public class MusicController : MonoBehaviour
    {
        public static MusicController ins;
        public AudioSource audioBG;
        public AudioSource audioSound;
        public AudioClip audioClipHit;
        public AudioClip audioClipWin;
        public AudioClip audioClipLose;
        private void Awake()
        {
            if (ins != null)
            {
                Destroy(gameObject);
            }
            else
            {
                ins = this;
            }
            DontDestroyOnLoad(gameObject);
        }
        // Start is called before the first frame update
        void Start()
        {
            MusicBg();
        }

        // Update is called once per frame
        void Update()
        {
        
        }
        public void MusicBg()
        {
            if (PlayerPrefs.GetInt("isMusic") == 0)
            {
                audioBG.Play();
            }
            else
            {
                audioBG.Stop();
            }
        }
        public void SoundGame(AudioClip audioClip_)
        {
            if (PlayerPrefs.GetInt("isSound") == 0)
            {
                audioSound.PlayOneShot(audioClip_);
            }
        }
    }
}
