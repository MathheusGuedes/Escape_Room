
using UnityEngine.SceneManagement;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    public void Restart(){
        SceneManager.LoadScene(0);
        
    }
    public void Close(){
        Application.Quit();
    }
}
