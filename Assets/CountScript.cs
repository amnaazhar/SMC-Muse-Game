using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CountScript : MonoBehaviour
{

	public static int spoolcount = 0;
	public static int batterycount = 0;
	public static int braincount = 0;
    // Start is called before the first frame update

	public void Update(){

		if (Input.GetKeyDown("escape")){

			SceneManager.LoadScene("GameHUD", LoadSceneMode.Single);

		}
	}
    public void AddSpool(){


    	spoolcount++;
    }
    public void AddBattery(){


    	batterycount++;
    }
    public void AddBrain(){


    	braincount++;
    }

    public int GetSpool(){


    	return spoolcount;
    }
    public int GetBattery(){


    	return batterycount;
    }
    public int GetBrain(){


    	return braincount;
    }


    // Update is called once per frame

}
