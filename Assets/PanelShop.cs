using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
namespace VanHuy
{
    public class PanelShop : MonoBehaviour
    {
        public static PanelShop ins;
        public int idUsing;
        public int coin;
        public bool isCheckBought = true;
        public Button bttExitShop;
        public TextMeshProUGUI txtCoin;
        public List<BttBuyHammer> listBuyHammers;
        public BttBuyHammer buyHammerSelect;
        private void Awake()
        {
            ins = this;
            Refresh();
            coin = PlayerPrefs.GetInt("Coin");
            txtCoin.text = coin.ToString();
        }
        // Start is called before the first frame update
        void Start()
        {
            bttExitShop.onClick.AddListener(OnClickExitShop);
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                coin = 10000;
                PlayerPrefs.SetInt("Coin", coin);
                txtCoin.text = coin.ToString();
            }
        }
        public void Refresh()
        {
            idUsing = PlayerPrefs.GetInt("IdUsingHammer");
        }
        public void OnclickBuyHammer(int a_,BttBuyHammer bttBuyHammer)
        {
            buyHammerSelect = bttBuyHammer;
            if (buyHammerSelect.indexBuy == 0)
            {
                if (coin >= buyHammerSelect.priceHammer)
                {
                    buyHammerSelect.indexBuy = 1;
                    idUsing = a_;
                    PlayerPrefs.SetInt("IdUsingHammer", idUsing);
                    PlayerPrefs.SetInt("StatusBuyHammer" + a_, buyHammerSelect.indexBuy);
                    coin -= buyHammerSelect.priceHammer;
                    PlayerPrefs.SetInt("Coin", coin); //save coin 
                    txtCoin.text = coin.ToString();
                    buyHammerSelect.btt.GetComponent<Image>().raycastTarget = false;
                }
                else
                {
                    Debug.Log("khong du tien");
                }
            }
            else
            {
                buyHammerSelect.indexBuy = 1;
                idUsing = a_;
                PlayerPrefs.SetInt("IdUsingHammer", idUsing);
                PlayerPrefs.SetInt("StatusBuyHammer" + a_, buyHammerSelect.indexBuy);
            }
            for (int i = 0; i < listBuyHammers.Count; i++)
            {
                if (listBuyHammers[i].indexBuy == 1 && listBuyHammers[i].index == idUsing) //Da mua va dang sd
                {
                    listBuyHammers[i].objPrice.SetActive(false);
                    listBuyHammers[i].objTickUsing.SetActive(true);
                    Debug.Log("Da mua va dang sd");
                    listBuyHammers[i].btt.GetComponent<Image>().raycastTarget = false;
                }
                else if (listBuyHammers[i].indexBuy == 1 && listBuyHammers[i].index != idUsing) //da mua nhung k sd
                {
                    listBuyHammers[i].objPrice.SetActive(false);
                    listBuyHammers[i].objTickUsing.SetActive(false);
                    Debug.Log("da mua nhung k sd");
                    listBuyHammers[i].btt.GetComponent<Image>().raycastTarget = true;

                }
                else if(listBuyHammers[i].indexBuy == 0)
                {
                    listBuyHammers[i].objPrice.SetActive(true);
                    listBuyHammers[i].objTickUsing.SetActive(false);
                    listBuyHammers[i].btt.GetComponent<Image>().raycastTarget = true;
                    Debug.Log("chua mua");
                }
            }
                /*for (int i = 0; i < listBuyHammers.Count; i++)
                {
                    if (i == a_)
                    {
                        if (listBuyHammers[i].indexBuy == 0)
                        {
                            if (coin >= listBuyHammers[i].priceHammer)
                            {
                                listBuyHammers[i].indexBuy = 1;
                                idUsing = i;
                                PlayerPrefs.SetInt("IdUsingHammer", idUsing);
                                listBuyHammers[i].objPrice.SetActive(false);
                                listBuyHammers[i].objTickUsing.SetActive(true);
                                //listBuyHammers[i].isBuy = true;
                                PlayerPrefs.SetInt("StatusBuyHammer" + i, listBuyHammers[i].indexBuy);

                                coin -= listBuyHammers[i].priceHammer;
                                PlayerPrefs.SetInt("Coin", coin); //save coin 
                                txtCoin.text = coin.ToString();
                                // isCheckBought = false;
                            }
                            else
                            {
                                //isCheckBought = true;
                                Debug.Log("Khong du tien");
                            }

                        }
                        else
                        {
                            //listBuyHammers[i].indexBuy = 1;
                            idUsing = i;
                            listBuyHammers[i].objPrice.SetActive(false);
                            listBuyHammers[i].objTickUsing.SetActive(true);
                            Debug.Log("da Mua va su dung");
                        }
                    }
                    else
                    {
                        if (listBuyHammers[i].indexBuy == 1 && idUsing != listBuyHammers[i].index)
                        {
                            listBuyHammers[i].objPrice.SetActive(false);
                            listBuyHammers[i].objTickUsing.SetActive(false);
                            Debug.Log("------ =" + i);
                        }
                    }
                }*/
            }
        public void OnClickExitShop()
        {
            gameObject.SetActive(false);
        }
    }
}
