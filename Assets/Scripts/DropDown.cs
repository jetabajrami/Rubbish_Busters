using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DropDown : MonoBehaviour
{
    public TextMeshProUGUI output;
    [SerializeField] public TextMeshProUGUI selectedCity;

    public void HandleInputData(int val = 0)
    {
        if (val == 0)
        {
            GlobalData.dropDownNr = val;
            output.text = "Welcome to Seattle Rubbish Busters";
            selectedCity.text = "Seattle";
        }
        else if (val == 1)
        {
            GlobalData.dropDownNr = val;
            output.text = "Welcome to New York Rubbish Busters";
            selectedCity.text = "New York";
        }
    }
}