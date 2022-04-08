using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] Text playerNameText;

    // Start is called before the first frame update
    void Start()
    {
        playerNameText.text = SaveManager.Instance.playerName;
        
    }

   

    
}
