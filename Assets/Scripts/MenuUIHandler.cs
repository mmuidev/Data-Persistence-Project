using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

#if UNITY_EDITOR
using UnityEditor;
#endif

[DefaultExecutionOrder(1000)]
public class MenuUIHandler : MonoBehaviour
{

    public Text highScoreText;
    public void Awake()
    {
        ScoreManager.Instance.LoadHighScore();

        highScoreText.text = $"Best Score : {ScoreManager.Instance.highScoreName} : {ScoreManager.Instance.highScore}";
    }

    public void SelectUserName(string name)
    {
        ScoreManager.Instance.userName = name;
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {

    #if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
    #else
        Application.Quit(); // original code to quit Unity player
    #endif
    }

}
