using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

[RequireComponent(typeof(Animator))]
public class SceneTransition : MonoBehaviour
{
    private static SceneTransition instance;
    private static bool playOpenAnimation = false;

    [SerializeField] private TextMeshProUGUI _loadingPercet;

    private Animator sceneAnimator;

    private AsyncOperation loadingSceneOperation;

    public static void StartLodingScene(string sceneName)
    {
        instance.sceneAnimator.SetTrigger("sceneLoad");
        instance.loadingSceneOperation = SceneManager.LoadSceneAsync(sceneName);
        instance.loadingSceneOperation.allowSceneActivation = false;
    }

    private void Start()
    {
        instance = this;

        sceneAnimator = GetComponent<Animator>();

        if (playOpenAnimation) sceneAnimator.SetTrigger("sceneOpen");
    }


    private void Update()
    {
        if (loadingSceneOperation != null)
        {
            _loadingPercet.text = Mathf.RoundToInt(loadingSceneOperation.progress * 100) + "%";

        }
    }

    private void OnAnimationOver()
    {
        playOpenAnimation = true;
        loadingSceneOperation.allowSceneActivation = true;
    }

}
