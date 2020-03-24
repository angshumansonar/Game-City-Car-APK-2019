using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class controlswitching : MonoBehaviour
{
    public GameObject con1;
    public GameObject con2;
    


    // Start is called before the first frame update
    void Start()
    {
        con1.SetActive(true);
        con2.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
       

        if (CrossPlatformInputManager.GetButtonDown("K"))
        {
            con1.SetActive(true);
            con2.SetActive(false);
            
        }

        if (CrossPlatformInputManager.GetButtonDown("M"))
        {
             con2.SetActive(true);
             con1.SetActive(false);
            
        }
       
        
    }
 
}
