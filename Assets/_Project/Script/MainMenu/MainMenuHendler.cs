using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MainMenuHendler : MonoBehaviour
{
    [SerializeField] MainMenu menuScreen;

    [SerializeField] BaseScreen  shopScreen;

    void Start()
    {
        menuScreen.StartScreen();

       
        menuScreen.PressShopButton(() =>
        {
            menuScreen.CloseScreen();
            shopScreen.StartScreen();
        });
    }


    public void BackToMenu()
    {

    }
}
