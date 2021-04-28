using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartGame : MonoBehaviour
{
    [SerializeField] private string[] textDialogStartGame;
    [SerializeField] private string[] textDialogEndGame;
    [SerializeField] private Text txt;
    [SerializeField] private int count = 0;
    [SerializeField] private GameObject pnlDialog ;
    
    void Start()
    {
        txt.text = textDialogStartGame[0];
        print("length is: " + textDialogStartGame.Length);
    }


    void Update()
    {
        
    }

    public void NextDialog(){
        count++;
        if(count >= textDialogStartGame.Length)
        {
            pnlDialog.SetActive(false);
        }
        else
        {
            txt.text = textDialogStartGame[count];
        }
        
    }
    
}
