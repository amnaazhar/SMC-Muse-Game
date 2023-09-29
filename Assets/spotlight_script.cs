using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class spotlight_script : MonoBehaviour
{

    public OSCReeive muse;
    public float upscale;
    float intensity;
    Vector3 original_scale;
    // Start is called before the first frame update
    void Start()
    {
        intensity = muse.Vgamma;
        original_scale = gameObject.transform.localScale;
        if (upscale == 0)
        {
            upscale = 5;
        }
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Gamma is " + muse.Vgamma);
        intensity = muse.Vgamma;
        if (muse.Vgamma > 0)
            //gameObject.transform.localScale = (1/(intensity * upscale)) * original_scale;
            gameObject.transform.localScale = map(intensity, 0,1, 0, upscale) * original_scale;
        else
            gameObject.transform.localScale = original_scale;
    }

    // Maps a value from ome arbitrary range to another arbitrary range
    public static float map(float value, float leftMin, float leftMax, float rightMin, float rightMax)
    {
        return rightMin + (value - leftMin) * (rightMax - rightMin) / (leftMax - leftMin);
    }
}
