using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Moving : MonoBehaviour
{
    //public bool open=true;
    public float speed = 1f;
    public Transform moving;
    float initialpositiony;
    float theposition;
    int randomtime;
    public GameManerger gamemanger;
    public Text score;
    public bool scoreopen = true;
    // Use this for initialization
    void Start()
    {
        initialpositiony = moving.position.y;//get the initial position of y axis
        InvokeRepeating("RandomTime", 0, 1);//repeat the randtime function
    }

    // Update is called once per frame
    void Update()
    {
        gamemanger.GetComponent<GameManerger>().open = false;//when it is false then GameManerger will not choose the randmole
        moving.Translate(0, speed * Time.deltaTime, 0);//goes up from the hole
        theposition = transform.position.y;//get the position of y axis
        

        if (theposition - initialpositiony > 1f)// when the moving distance greater than 1, the mole stop
        {
            speed = 0f;
            gamemanger.GetComponent<GameManerger>().molespeed = false;//when mole can not go up
            if (randomtime > 0)
            {
                speed = -1;
            }
        }
        if (theposition - initialpositiony <= 0f)
        {
            if (gamemanger.GetComponent<GameManerger>().molespeed == true)
            {
                speed = 1;
            }
            else if (gamemanger.GetComponent<GameManerger>().molespeed == false)
            {
                gamemanger.GetComponent<GameManerger>().open = true;
                this.enabled = false;
            }

        }
    }

    void OnMouseDown()
    {
        if(tag=="molew" && scoreopen==true)
        {
            score.GetComponent<Score>().Scoretotal += 1;
            scoreopen = false;
        }
        if(tag=="moler"&& scoreopen==true)
        {
            score.GetComponent<Score>().Scoretotal -= 1;
            scoreopen = false;
        }
        speed = -1f;
        gamemanger.GetComponent<GameManerger>().molespeed = false;
        if (theposition - initialpositiony <= 0f)
        {
            this.enabled = false;
        }
    }

    void RandomTime()
    {
        randomtime = Random.Range(0, 5);
    }
        


}
