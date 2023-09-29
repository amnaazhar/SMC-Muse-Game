using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectControl : MonoBehaviour
{
    public OSCReeive muse;
    //public GameObject muse;
    //public GettingStartedReceiving muse;
    public float Vgamma;
    
    // Start is called before the first frame update
    void Start()
    {
        //muse = muse.GetComponent<GettingStartedReceiving>();
    }

    // Update is called once per frame
    void Update()
    {
        Vgamma = muse.Vgamma;
    }
}
