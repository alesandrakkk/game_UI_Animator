using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;


[RequireComponent(typeof(CanvasGroup))]
public class MainMenu : BaseScreen
{
    [SerializeField] private Button _gameButton, _optionsButton, _shopButton;

    private CanvasGroup _menuScreen;

    [SerializeField] private float _animationDuration = 0.6f;

    private void Awake()
    {
        _menuScreen = GetComponent<CanvasGroup>();
    }


    public override void StartScreen()
    {
        base.StartScreen();
        Debug.Log("Menu screen start screen");

        _menuScreen.interactable = true;
        _menuScreen.blocksRaycasts = true;
        _menuScreen.DOFade(1.0f, _animationDuration);

    }

    public override void CloseScreen()
    {
        base.CloseScreen();
        _menuScreen.interactable = false;
        _menuScreen.blocksRaycasts = false;
        _menuScreen.DOFade(0.0f, _animationDuration);
    }

    public void PressShopButton(Action onShopPressed)
    {
        _shopButton.onClick.AddListener(() => onShopPressed?.Invoke());
    }
}
