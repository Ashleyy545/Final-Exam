using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class adjusting : MonoBehaviour
{
    public Text speed;
    public Text size;

    
    // Update is called once per frame
    void Update()
    {
        size.text = DropDownSelect.sizeTxt;
        speed.text = DropDownSelect.speedTxt;

    }
}
