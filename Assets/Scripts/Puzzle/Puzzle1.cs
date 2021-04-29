using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro ;

public class Puzzle1 : MonoBehaviour
{
    
    [SerializeField] private int tryValue = 0;
    [SerializeField] private bool addPoint = false;
    [SerializeField] private bool win = false;
    [SerializeField] private GameManager _gameManager;
    [SerializeField] private List<Button> btns;
    [SerializeField] private string code;
    [SerializeField] private string newCode;
    [SerializeField] private TextMeshProUGUI result;

    void Awake()
    {
        code = "725941";
    }

    void Update()
    {
        Win();
        Lose();
    }

    public void Win()
    {
        if(newCode == code && !addPoint){
            win = true;
            foreach (Button item in btns)
            {
                item.interactable  = false;
                ColorBlock colors = item.colors;

                colors.normalColor = Color.green;
                item.GetComponentInChildren<TextMeshProUGUI>().color  = new Color32(0, 255, 0, 155);
            }


            addPoint = true;
            if(addPoint)
            {
                _gameManager.AddPoint();
                addPoint = false;
                code = "";
            }
        }
        
    }

    public void Lose()
    {
        if(tryValue >= 6 && !win){
            foreach (Button item in btns)
            {
                item.interactable = true;
            }
            tryValue = 0;
            newCode = "";
            _gameManager.loss = true; //enviar loss true para o ShakeMe (fazer o botao balançar)
        }
        
    }
   
    public void ButtonPuzzle(string value){
        foreach (Button item in btns)
        {
            if(item.GetComponentInChildren<TextMeshProUGUI>().text == value)
            {
                item.interactable = false;
            }
        }
        newCode = newCode + value;
        result.text = newCode;
        tryValue++;
    }


}
