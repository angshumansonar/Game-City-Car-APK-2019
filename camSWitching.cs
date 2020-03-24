using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class camSWitching : MonoBehaviour
{

    public int selectedcam = 0;

    // Start is called before the first frame update
    void Start()
    {
        selectcam();
    }

    // Update is called once per frame
    void Update()
    {
        int previousSelectedcam = selectedcam;

        if (CrossPlatformInputManager.GetButtonDown("Alpha1"))
        {
            selectedcam = 0;
        }
        if (CrossPlatformInputManager.GetButtonDown("Alpha2"))
        {
            selectedcam = 1;
        }
        if (CrossPlatformInputManager.GetButtonDown("Alpha3"))
        {
            selectedcam = 2;
        }
        if (CrossPlatformInputManager.GetButtonDown("Alpha4"))
        {
            selectedcam = 3;
        }
        if (CrossPlatformInputManager.GetButtonDown("Alpha5"))
        {
            selectedcam = 4;
        }


        if (previousSelectedcam != selectedcam)
        {
            selectcam();
        }
    }
    void selectcam()
    {
        int i = 0;
        foreach (Transform weapon in transform)
        {
            if (i == selectedcam)
                weapon.gameObject.SetActive(true);
            else
                weapon.gameObject.SetActive(false);
            i++;


        }
    }
}
