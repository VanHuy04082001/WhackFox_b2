using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace VanHuy
{
    public class PanelSelectLv : MonoBehaviour
    {
        public Button bttExitSelectLv;
        public List<BttSelectLv> listBttSelectLv;
        private void Awake()
        {
            RefreshLv();
        }
        // Start is called before the first frame update
        void Start()
        {
            bttExitSelectLv.onClick.AddListener(OnClickExitSelectLv);
        }

        // Update is called once per frame
        void Update()
        {
        
        }
        public void RefreshLv()
        {
            for (int i = 0; i < listBttSelectLv.Count; i++)
            {
                listBttSelectLv[i].index = i;
                listBttSelectLv[i].txtLv.text = (i + 1).ToString();
            }
        }
        public void OnClickExitSelectLv()
        {
            gameObject.SetActive(false);
        }
    }
}
