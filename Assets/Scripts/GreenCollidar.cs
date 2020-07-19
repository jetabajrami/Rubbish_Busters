using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GreenCollidar : MonoBehaviour
{
    public void Start()
    {
        FindObjectOfType<SpawnTrash>().uiObject.SetActive(false);
        FindObjectOfType<SpawnTrash>().lostPointText.SetActive(false);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(GlobalData.dropDownNr);

        if (GlobalData.getBinColor(collision.gameObject.name) != "Green")
        {
            if (FindObjectOfType<SpawnTrash>().lostPoint <= 2)
            {
                FindObjectOfType<SpawnTrash>().uiObject.SetActive(false);
                FindObjectOfType<SpawnTrash>().lostPointText.GetComponent<lostBinText>().changeText(GlobalData.getBinName(collision.gameObject.name));
                FindObjectOfType<SpawnTrash>().lostPointText.SetActive(true);
                FindObjectOfType<SpawnTrash>().lostPoint += 1;

                if (FindObjectOfType<SpawnTrash>().lostPoint == 2)

                {
                    GlobalData.lostTrashIndex[0] = GlobalData.currentTrashIndex;
                    GlobalData.lostTrashObj[0] = GlobalData.currentTrashObj;
                    // I am geting the treshObject and pushing that to the Global Array
                    if (FindObjectOfType<SpawnTrash>().lifeThree.name == "Earth 3")
                    {
                        FindObjectOfType<SpawnTrash>().lifeThree.AddComponent<Rigidbody2D>().gravityScale = 6f;
                    }
                }
                else if (FindObjectOfType<SpawnTrash>().lostPoint == 3)
                {
                    GlobalData.lostTrashIndex[1] = GlobalData.currentTrashIndex;
                    GlobalData.lostTrashObj[1] = GlobalData.currentTrashObj;
                    if (FindObjectOfType<SpawnTrash>().lifeTwo.name == "Earth 2")
                    {
                        FindObjectOfType<SpawnTrash>().lifeTwo.AddComponent<Rigidbody2D>().gravityScale = 6f;
                    }
                    //Destroy(FindObjectOfType<SpawnTrash>().lifeTwo);
                }
            }
            else if (FindObjectOfType<SpawnTrash>().lostPoint >= 2)
            {
                if (FindObjectOfType<SpawnTrash>().lifeOne.name == "Earth 1")
                {
                    FindObjectOfType<SpawnTrash>().lifeOne.AddComponent<Rigidbody2D>().gravityScale = 6f;
                }
                GlobalData.speed = 0.8f;
                SceneManager.LoadScene("Game Over");
            }
        }
        else if (GlobalData.getBinColor(collision.gameObject.name) == "Green")
        {
            FindObjectOfType<SpawnTrash>().lostPointText.SetActive(false);
            FindObjectOfType<SpawnTrash>().uiObject.SetActive(true);
            GlobalData.points += 100;
            FindObjectOfType<SpawnTrash>().pointsText.text = GlobalData.points.ToString();
        }
    }

    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    GetComponent<AudioSource>().Play();
    //}  
}
