using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public void StartGame(string s)
    {
        SceneManager.LoadScene(1);
        
    }

    public void SetPalyerName(string s)
    {
        SaveManager.Instance.playerName = s;
    }
}
