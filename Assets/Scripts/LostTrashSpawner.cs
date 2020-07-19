using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LostTrashSpawner : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI pointsTextResult;

    private void Start()
    {
        pointsTextResult.text = "Congratulations, you scored " + GlobalData.points.ToString() + "!...";
    }
    //public GameObject[] lostObjectArray;


    //// Start is called before the first frame update
    //void Start()
    //{
    //    //int randomIndex = Random.Range(0, Trash.Length);
    //    //GameObject currentObject = Instantiate(Trash[randomIndex], transform.position, Quaternion.identity);
    //    for (int i = 0; i < GlobalData.lostTrashIndex.Length; i++)
    //    {
    //        //transform.position += new Vector3(0, 0, 0);
    //        GameObject currentObject = Instantiate(lostObjectArray[GlobalData.lostTrashIndex[i]], transform.position, Quaternion.identity);
    //        currentObject.transform.position = new Vector3(0, 0, 0);
    //    }

    //}

    //// Update is called once per frame
    //void Update()
    //{

    //}


}
