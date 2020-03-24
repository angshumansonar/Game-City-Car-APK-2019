using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class imageswitching : MonoBehaviour
{
    public int selectedweapon = 0;
    public int index = 0;

    //public AudioSource switchingsfx;


    void Start()
    {
        selectweapon();

    }


    void Update()
    {
        int previousSelectedWeapon = selectedweapon;

        if (selectedweapon <= 4)
        {
            if (CrossPlatformInputManager.GetButtonDown("Alpha8"))
            {

                selectedweapon = selectedweapon + 1;
            }
        }

        if (selectedweapon >= 1)
        {
            if (CrossPlatformInputManager.GetButtonDown("Alpha9"))
            {

                selectedweapon = selectedweapon - 1;
            }
        }


        if (previousSelectedWeapon != selectedweapon)
        {
            // switchingsfx.Play();
            selectweapon();

        }
    }
    void selectweapon()
    {

        int i = 0;
        foreach (Transform weapon in transform)
        {
            if (i == selectedweapon)
            {

                weapon.gameObject.SetActive(true);

            }
            else
                weapon.gameObject.SetActive(false);
            i++;


        }
    }
}
