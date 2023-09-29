using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HUD : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void StartButton()
    {
  		SceneManager.LoadScene("Level1", LoadSceneMode.Single);
        
    }
    public void QuitButton()
    {

    	Application.Quit();
        
    }
}
