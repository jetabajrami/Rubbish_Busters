using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GlobalData
{
    public static int currentTrashIndex;
    public static GameObject currentTrashObj;
    public static int[] lostTrashIndex = new int[3];
    public static GameObject[] lostTrashObj = new GameObject[3];
    public static int points = 0;
    public static float speed = 0.8f;
    public static int dropDownNr = 0;
    
    public static Dictionary<string, string> seattleHash = new Dictionary<string, string>()
    {
        { "Bottle", "Blue"},
        { "Foil and foil trays", "Blue"},
        { "Small lid (less than 3 inches wide)", "Black"},
        { "Apple", "Green"},
        { "Non-fluorescent bulbs", "Black"},
    };

    public static Dictionary<string, string> nycHash = new Dictionary<string, string>()
    {
        { "Bottle", "Blue" },
        { "Foil and foil trays", "Blue" },
        { "Small lid (less than 3 inches wide)", "Blue" },
        { "Apple", "Black"},
        { "Non-fluorescent bulbs", "Blue"},
    };

    public static Dictionary<string, string> nycBinConversion = new Dictionary<string, string>()
    {
        { "Blue", "Metal Glass Plastic and Cartons Recycling" },
        { "Green", "Papper" },
        { "Black", "Garbage" },

    };

    public static Dictionary<string, string> seattleBinConversion = new Dictionary<string, string>()
    {
        { "Blue", "Recycle" },
        { "Green", "Food & Compostables" },
        { "Black", "Garbage" },
    };

    public static string getBinColor(string nameObject)
    {
        if (dropDownNr == 0)
        {

            //Debug.Log(nameObject);
            //Debug.Log(cloneRemoval(nameObject));
            //Debug.Log(seattleHash["Foil and foil trays"]);
            //Debug.Log(seattleHash[nameObject.Trim()]);
            //Debug.Log(seattleHash);
            return seattleHash[cloneRemoval(nameObject.Trim())];
        }
        else if (dropDownNr == 1)
        {
            return nycHash[cloneRemoval(nameObject.Trim())];
        }
        return "";
    }

    public static string getBinName(string nameObject)
    {
        if (dropDownNr == 0)
        {
            return seattleBinConversion[seattleHash[cloneRemoval(nameObject.Trim())]];
        }
        else if (dropDownNr == 1)
        {
            return nycBinConversion[nycHash[cloneRemoval(nameObject.Trim())]];
        }
        return "";
    }

    public static string cloneRemoval(string nameObject)
    {
        return nameObject.Replace("(Clone)", "");
    }
}

