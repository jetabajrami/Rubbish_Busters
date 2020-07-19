using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Trash : MonoBehaviour
{
    //Vertical movemant
    private float prviuseTime;
    public float fullTime = 2.0f;

    public static float height = 20.0f;
    public static float width = 16.20f;

    private Rigidbody2D rb2D;
    //private float thrust = 100.0f;



    IEnumerator WaitForSec()
    {
        yield return new WaitForSeconds(1.5f);
        FindObjectOfType<GreenCollidar>().Start();
        FindObjectOfType<BlackCollider>().Start();
        FindObjectOfType<BlueCollider>().Start();  
    }

    void Start()
    {
        IncreasSpeed();
    }

    public void IncreasSpeed()
    {
        rb2D = gameObject.GetComponent<Rigidbody2D>();
   
        rb2D.velocity += new Vector2(0f, - GlobalData.speed);
        GlobalData.speed += 0.5f;
    }


    // Update is called once per frame

    void Update()

    { //Every frame of the game

        if (Input.GetKeyDown(KeyCode.LeftArrow))//Check Left arrow key input
        {
            transform.position += new Vector3(-1, 0, 0); //Shifrin to the left
   
            if (!ValidMove())//Check if it's valid position after every move!
            {
                transform.position -= new Vector3(-1, 0, 0);
            }
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow)) //Check Right arrow key input
        {
            transform.position += new Vector3(1, 0, 0); //Shifrin to the right
            if (!ValidMove())//Check if it's valid position after every move!
            {
                transform.position -= new Vector3(1, 0, 0);
            }
        }
       

        ////Vertical movemant
        //Full time is the time before trash object moves down, so each time that the diferenc betwin the current time and and previus time
        // is bigger than the full time we make our trash to fell down.
        //if (Time.time - prviuseTime > fullTime)
        //If the down arrow is prest the speed of the trash its going to be raised if not it will fall down in normal speed.
        if (Time.time - prviuseTime > (Input.GetKey(KeyCode.DownArrow)? fullTime/10 :fullTime))
        {
            transform.position += new Vector3(0, -1, 0);
            
            if (!ValidMove())//Check if it's valid position after every move!
            {

                transform.position -= new Vector3(0, -1, 0);
                this.enabled = false;
                FindObjectOfType<SpawnTrash>().NewTrash();
                StartCoroutine(WaitForSec());
            }
            //Once the tresh is fall down we have to set previuseTime to Time.time
            prviuseTime = Time.time;
        }  
    }

   
   
   

    bool ValidMove()
    {
        foreach (Transform children in transform) //Browse all childrens
        {
            float roundedX = Mathf.RoundToInt(children.transform.position.x);// Round x position
            float roundedY = Mathf.RoundToInt(children.transform.position.y);// Round y position

            if (roundedX <= 0.0f || roundedX >= width || roundedY <= 0.0f || roundedY >= height) //If one it's bigger than the grid size
            {
                return false; // return false
            }

        }

        return true;//if none are outside return true
    }

    //Playing the sound when collision happens.
    private void OnCollisionEnter2D(Collision2D collision)
    {
        GetComponent<AudioSource>().Play();
    }


}


