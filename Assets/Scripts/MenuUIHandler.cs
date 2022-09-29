using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class MenuUIHandler : MonoBehaviour
{
    public string playerName;

    public InputField inputField;

    public Text highScore;

    // Start is called before the first frame update
    void Start()
    {
        WinnerList.Instance.LoadWinnerData();
        highScore.text = "Best Score: " + WinnerList.Instance.bestPlayer + ": " + WinnerList.Instance.bestScore;
    }

    public void SaveName()
    {
        playerName = inputField.text;
        WinnerList.Instance.playerName = playerName;
    }

    public void StartNext()
    {
        SceneManager.LoadScene(1);
    }
}
