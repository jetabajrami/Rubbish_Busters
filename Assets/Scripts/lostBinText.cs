using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class lostBinText : MonoBehaviour
{
    TMPro.TextMeshProUGUI message;

    public void changeText(string trashType)
    {
        message = GetComponent<TMPro.TextMeshProUGUI>();
        message.text = "Wrong Bin!!! Trash Belongs to " + trashType;

    }
}
