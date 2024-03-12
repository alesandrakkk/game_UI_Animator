using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

[RequireComponent(typeof(CanvasGroup))]
public class BaseScreen : UIScreen
{
    private CanvasGroup _menuScreen;

    [SerializeField] private float _animationDuration = 0.6f;


    private void Awake()
    {
        _menuScreen = GetComponent<CanvasGroup>();
    }

    public override void CloseScreen()
    {
        gameObject.SetActive(false);

        _menuScreen.interactable = false;
        _menuScreen.blocksRaycasts = false;
        _menuScreen.DOFade(0.0f, _animationDuration);
    }

    public override void StartScreen()
    {
        Debug.Log("Base Screen");

        gameObject.SetActive(true);

        _menuScreen.interactable = true;
        _menuScreen.blocksRaycasts = true;
        _menuScreen.DOFade(1.0f, _animationDuration);
    }
}
