using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class lightonoff : MonoBehaviour
{
    public static bool islight=false;
    public GameObject lightset;
    public GameObject lighton;
    public GameObject lightoff;

    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        if (CrossPlatformInputManager.GetButtonDown("L"))
        {
           
            islight = !islight;
            return;
        }
        if (islight)
        {

            lightset.SetActive(true);
            lighton.SetActive(true);
            lightoff.SetActive(false);

        }
        else
        {

            lightset.SetActive(false);
            lightoff.SetActive(true);
            lighton.SetActive(false);
        }

    }
}
