using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
namespace VanHuy
{
    public class BttBuyHammer : MonoBehaviour
    {
        public int index;
        public int indexBuy; //0 la chua mua.  //1 la da mua nhung chua su dung. //2 la da mua va dang su dung
        public int priceHammer;
        public bool isBuy;
        public GameObject objPrice;
        public GameObject objTickUsing;
        public Button btt;
        // Start is called before the first frame update
        void Start()
        {
            btt.onClick.AddListener(OnClick);
            LoadStatusBuy();
        }

        // Update is called once per frame
        void Update()
        {
        
        }
        public void OnClick()
        {
            PanelShop.ins.OnclickBuyHammer(index,this);
        }
        public void SaveStatusBuy()
        {
            PlayerPrefs.SetInt("StatusBuyHammer" + index, indexBuy);
            PlayerPrefs.Save();
        }
        public void LoadStatusBuy()
        {
            if (index != 0)
            {
                indexBuy = PlayerPrefs.GetInt("StatusBuyHammer" + index);
            }
            else
            {
                PlayerPrefs.SetInt("StatusBuyHammer" + index, 1);
                indexBuy = PlayerPrefs.GetInt("StatusBuyHammer" + index);
            }
            if (indexBuy == 1 && PanelShop.ins.idUsing == index)
            {
                objPrice.SetActive(false);
                objTickUsing.SetActive(true);
                btt.GetComponent<Image>().raycastTarget = false;
            }
            else if (indexBuy == 1 && PanelShop.ins.idUsing != index)
            {
                objPrice.SetActive(false);
                objTickUsing.SetActive(false);
            }
        }
    }
}
