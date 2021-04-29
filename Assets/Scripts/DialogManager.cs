using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogManager : MonoBehaviour
{
    [SerializeField] private string[] textDialog;
    [SerializeField] private Text txt;
    [SerializeField] private int count = 0;
    [SerializeField] private GameObject pnlDialog ;
    [SerializeField] private GameManager _gameManager;
    [SerializeField] public bool inDialog = true;
    
    void Start()
    {
        txt.text = textDialog[0];
        _gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        if(pnlDialog.activeSelf)
        {
            Time.timeScale = 0f;
        }
    }
    public void NextDialog(){
        count++;
        if(count >= textDialog.Length)
        {
            pnlDialog.SetActive(false);
            Time.timeScale = 1f;
            inDialog = false;
        }
        else
        {
            inDialog = true;
            txt.text = textDialog[count];
        }
        
    }
    
}
