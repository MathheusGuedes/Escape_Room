using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelManager : MonoBehaviour
{
    [SerializeField] GameObject[] panel;
    public bool cursorLock;

    void Awake()
    {
        cursorLock = true;
        
    }
    void Update()
    {
        if(cursorLock)
        {
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
            foreach (GameObject item in panel)
            {
                if(item.activeSelf)
                {   
                    print("PAINEL ESTA ATIVO");
                    cursorLock = false;
                    StartCoroutine("WaitPanel", item.gameObject);
                }
            }
        }

    }

    IEnumerator WaitPanel(GameObject panel)
    {
        while(cursorLock == false)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;            
            if(!panel.activeSelf)
            {
                cursorLock = true;
                print("PAINEL NAO ESTA ATIVO");
                yield break;
            }
            yield return new WaitForSeconds(0.5f);
        }
        
    }
    

}
