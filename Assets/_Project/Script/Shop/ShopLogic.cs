using Assets._Project.Script.Button;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace Assets._Project.Script.Shop
{
    public class ShopLogic 
    {
        private TextMeshProUGUI _myMoneyUI;

        private int _myMoney = 1000;
        public int Money { get => _myMoney; set => _myMoney = value; }

        private ShopItem _item;
                
        private List<ShopItem> items = new();
        private int shopItemCount = 20;

        public ItemData scriptObj;

        private BuyButton _buyButton;

             

        internal void InitShop(ShopItem shopItemPrefab, RectTransform layout)
        {
            for (int i = 0; i < shopItemCount; i++)
            {
                var item = GameObject.Instantiate(shopItemPrefab, layout);

                item.image.sprite = scriptObj.GetSprite();
                BuyAccess(item);
                items.Add(item);
            }

        }



        private void BuyAccess( ShopItem item)
        {
            if (Money < item.Price)
            {
                _buyButton.enabled = false;
            }
            else
            {
               
                BuyItem();
            }
        }

        private void BuyItem()
        {
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].Price <= Money)
                {
                   Money -= items[i].Price;

                   
                }

               
            }
        }
    }
}