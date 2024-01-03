using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace VanHuy
{
    public class PanelSetting : MonoBehaviour
    {
        public Image imgSoundOn;
        public Image imgSoundOff;
        public Image imgMusicOn;
        public Image imgMusicOff;
        public Button bttSoundOn;
        public Button bttSoundOff;
        public Button bttMusicOn;
        public Button bttMusicOff;
        // Start is called before the first frame update
        void Start()
        {
            bttSoundOn.onClick.AddListener(OnClickSoundOn);
            bttSoundOff.onClick.AddListener(OnClickSoundOff);
            bttMusicOn.onClick.AddListener(OnClickMusicOn);
            bttMusicOff.onClick.AddListener(OnClickMusicOff);
            LoadData();
        }

        // Update is called once per frame
        void Update()
        {
            
        }
        public void LoadData()
        {
            if (PlayerPrefs.GetInt("isSound") == 0)
            {
                SetSoundOn();
            }
            else
            {
                SetSoundOff();
            }
            if (PlayerPrefs.GetInt("isMusic") == 0)
            {
                SetMusicOn();
            }
            else
            {
                SetMusicOff();
            }
        }
        public void OnClickSoundOn()
        {
            SetSoundOn();
            PlayerPrefs.SetInt("isSound", 0);
        }
        public void OnClickSoundOff()
        {
            SetSoundOff();
            PlayerPrefs.SetInt("isSound", 1);
        }
        public void OnClickMusicOn()
        {
            SetMusicOn();
            PlayerPrefs.SetInt("isMusic", 0);
            MusicController.ins.MusicBg();
        }
        public void OnClickMusicOff()
        {
            SetMusicOff();
            PlayerPrefs.SetInt("isMusic", 1);
            MusicController.ins.MusicBg();
        }
        void SetSoundOn()
        {
            imgSoundOn.gameObject.SetActive(true);
            imgSoundOff.gameObject.SetActive(false);
        }
        void SetSoundOff()
        {
            imgSoundOn.gameObject.SetActive(false);
            imgSoundOff.gameObject.SetActive(true);
        }
        void SetMusicOn()
        {
            imgMusicOn.gameObject.SetActive(true);
            imgMusicOff.gameObject.SetActive(false);
        }
        void SetMusicOff()
        {
            imgMusicOn.gameObject.SetActive(false);
            imgMusicOff.gameObject.SetActive(true);
        }
    }
}
