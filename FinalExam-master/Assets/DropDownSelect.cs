using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class DropDownSelect : MonoBehaviour
{
    public Dropdown size;
    public Dropdown speed;


    public static string sizeTxt;
    public static string speedTxt;

    public Text sizes;
    public Text speeds;


    void Update()
    {

        switch (size.value)
        {
            case 1:
                sizes.text = "Small";
                sizeTxt = "Small";
                break;
            case 2:
                sizes.text = "Medium";
                sizeTxt = "Medium";
                break;
            case 3:
                sizes.text = "Large";
                sizeTxt = "Large";
                break;
            default:
                sizes.text = "Please Select";
                sizeTxt = "Please Select";
                break;
        }

        switch (speed.value)
        {
            case 1:
                speeds.text = "Slow";
                speedTxt = "Slow";
                break;
            case 2:
                speeds.text = "Medium";
                speedTxt = "Medium";
                break;
            case 3:
                speeds.text = "Fast";
                speedTxt = "Fast";
                break;
            default:
                speedTxt = "Please Select";
                speeds.text = "Please Select";
                break;
        }



    }

}
