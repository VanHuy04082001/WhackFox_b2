using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
namespace VanHuy
{
    public class BttSelectLv : MonoBehaviour
    {
        public int index;
        public TextMeshProUGUI txtLv;
        Button btt;
        // Start is called before the first frame update
        void Start()
        {
            btt = GetComponent<Button>();
            btt.onClick.AddListener(ClickLv);
        }

        // Update is called once per frame
        void Update()
        {
        
        }
        void ClickLv()
        {
            Debug.Log("Load");
            PlayerPrefs.SetInt("IndexLv", index);
            SceneManager.LoadScene("GamePlay");
        }
    }
}
