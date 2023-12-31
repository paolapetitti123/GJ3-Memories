using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIButtonManager : MonoBehaviour
{

    [SerializeField] Button _replayButton;
    [SerializeField] Button _introButton;

    [SerializeField] Button _creditsButton;
    [SerializeField] Button _exitButton;
    [SerializeField] Button _menuButton;


    // Start is called before the first frame update
    void Start()
    {
        _replayButton.onClick.AddListener(Replay);
        _introButton.onClick.AddListener(Intro);
        _creditsButton.onClick.AddListener(Credits);
        _exitButton.onClick.AddListener(ExitGame);
        _menuButton.onClick.AddListener(MainMenu);

    }

    public void Replay()
    {
        GameStateManager.Instance.LoadScene(GameStateManager.Scene.GamePlay);
    }

    public void Credits()
    {
        GameStateManager.Instance.LoadScene(GameStateManager.Scene.GameCredits);
    }


    public void Intro()
    {
        GameStateManager.Instance.LoadScene(GameStateManager.Scene.Intro);
    }
    public void MainMenu()
    {
        if (_menuButton == null)
        {

        }
        else
        {
            GameStateManager.Instance.LoadScene(GameStateManager.Scene.MainMenu);
        }
    }

    public void ExitGame()
    {
        if (_exitButton == null)
        {

        }
        else
        {
            Application.Quit();

        }
    }
}
