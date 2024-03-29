using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
namespace VanHuy
{
    public class PanelWin : MonoBehaviour
    {
        public TextMeshProUGUI txtScoreResult;
        public Button bttNextLv;
        public Button bttHome;
        // Start is called before the first frame update
        void Start()
        {
            txtScoreResult.text = LogicGame.ins.gameController.score.ToString();
            bttNextLv.onClick.AddListener(OnClickNextLv);
            bttHome.onClick.AddListener(OnClickHome);
        }

        // Update is called once per frame
        void Update()
        {
        
        }
        public void OnClickNextLv()
        {
            int a = LogicGame.ins.gameController.indexLv + 1;
            PlayerPrefs.SetInt("IndexLv", a);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        public void OnClickHome()
        {
            SceneManager.LoadScene("GameHome");
        }
    }
}
