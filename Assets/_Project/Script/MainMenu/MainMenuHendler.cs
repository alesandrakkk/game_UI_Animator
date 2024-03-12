using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuHendler : MonoBehaviour
{
    [SerializeField] MainMenu menuScreen;

    [SerializeField] BaseScreen gameScreen, shopScreen;

    void Start()
    {
        menuScreen.StartScreen();

        menuScreen.PressStartButton(() =>
        {
            menuScreen.CloseScreen();
            gameScreen.StartScreen();
        });

        menuScreen.PressShopButton(() =>
        {
            menuScreen.CloseScreen();
            shopScreen.StartScreen();
        });
    }
}
