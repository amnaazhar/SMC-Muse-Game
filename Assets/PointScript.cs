using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace UnityStandardAssets._2D
{
    public class PointScript : MonoBehaviour
    {

        public CountScript countscript;
        public Text score;
        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.tag == "Player" && this.enabled == true)
            {	
                
            	if(this.gameObject.tag == "spool"){
                    this.enabled = false;
                    countscript.AddSpool();
                    score.text = "x" + countscript.GetSpool().ToString();
                    Destroy(this.gameObject);
                }
                else if(this.gameObject.tag == "battery"){
                    this.enabled = false;
                    countscript.AddBattery();
                    score.text = "x" + countscript.GetBattery().ToString();
                    Debug.Log("PLAER IS HEE");
                    Destroy(this.gameObject);
                }
                else if(this.gameObject.tag == "brain"){
                    this.enabled = false;
                    countscript.AddBrain();
                    score.text = "x" + countscript.GetBrain().ToString();
                    Destroy(this.gameObject);
                }

            }
        }
    }
}
