using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace VanHuy
{
    public class PaneHome : MonoBehaviour
    {
        public Button bttPlay;
        public Button bttShop;
        public GameObject panelShop;
        public GameObject panelSelectLv;
        // Start is called before the first frame update
        void Start()
        {
            bttShop.onClick.AddListener(OnClickShop);
            bttPlay.onClick.AddListener(OnClickSelectLv);
        }

        // Update is called once per frame
        void Update()
        {
        
        }
        public void OnClickShop()
        {
            panelShop.SetActive(true);
        }
        public void OnClickSelectLv()
        {
            panelSelectLv.SetActive(true);
        }
    }
}
