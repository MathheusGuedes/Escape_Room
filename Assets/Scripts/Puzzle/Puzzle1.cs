using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puzzle1 : MonoBehaviour
{
    [SerializeField]
    private int valueWin = 0;
    [SerializeField]
    private int valueAux = 0;
    [SerializeField]
    private int tryValue = 0;
    [SerializeField]
    private bool addPoint = false;
    [SerializeField]
    private bool win = false;
    [SerializeField]
    private GameManager _gameManager;
    [SerializeField]
    private List<Button> btns;

    

    void Update()
    {
        Win();
        Lose();
    }

    public void Win()
    {
        if(valueWin >= 6 && !addPoint){
            win = true;
            foreach (Button item in btns)
            {
                item.interactable  = false;
                /* ColorBlock colors = item.colors;

                colors.normalColor = Color.green;
                item.colors = colors;*/
            }


            addPoint = true;
            if(addPoint)
            {
                _gameManager.AddPoint();
                addPoint = false;
                valueWin = 0;
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
            valueWin = 0;
            valueAux = 0;
            _gameManager.loss = true; //enviar loss true para o ShakeMe (fazer o botao balançar)
        }
        
    }
   
    public void ButtonPuzzle(int value){
        btns[value-1].interactable = false;
        tryValue++;
        if(value > valueAux && valueWin != 6) valueWin++;

        valueAux = value;
    }


}
