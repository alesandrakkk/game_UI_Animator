using Assets._Project.Script.Shop;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class ShopScreen : BaseScreen
{
    [SerializeField] ButtonExit _backButton;
    [SerializeField] MainMenu mainMenu;

    [SerializeField] private TextMeshProUGUI _myMoneyUI;
    private ShopLogic shop;



    [SerializeField] private ShopItem _shopItemPrefab;
    [SerializeField] private ItemData _icon;
    [SerializeField] private RectTransform _layout;

    private void Start()
    {

        _myMoneyUI.text = "Money: " + shop.Money.ToString();
    }

    public override void StartScreen()
    {
        base.StartScreen();

        shop = new ShopLogic();
        shop.InitShop(_shopItemPrefab, _layout);
        shop.scriptObj = _icon;
        

        _backButton.AddListener(BackToMenu);

    }

    private void BackToMenu()
    {
        CloseScreen();
        mainMenu.StartScreen();
    }

    
}
