using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Moving7 : MonoBehaviour
{
    //public bool open=true;
    public float speed = 1f;
    public Transform moving;
    float initialpositiony;
    //float initialpositionx;
    float theposition;
    int randomtime;
    public GameManerger gamemanger;
    public Text score;
    public bool scoreopen = true;
    // Use this for initialization
    void Start()
    {
        initialpositiony = moving.position.y;
        InvokeRepeating("RandomTime", 0, 1);
    }

    // Update is called once per frame
    void Update()
    {
        gamemanger.GetComponent<GameManerger>().openhole7 = false;
        moving.Translate(0, speed * Time.deltaTime, 0);
        theposition = transform.position.y;
        

        if (theposition - initialpositiony > 1f)
        {
            speed = 0f;
            gamemanger.GetComponent<GameManerger>().molespeed7 = false;
           
            if (randomtime > 3)
            {
                speed = -1;
            }
        }
        if (theposition - initialpositiony <= 0f)
        {
            
            if (gamemanger.GetComponent<GameManerger>().molespeed7 == true)
            {
                speed = 1;
            }
            else if (gamemanger.GetComponent<GameManerger>().molespeed7 == false)
            {
                gamemanger.GetComponent<GameManerger>().openhole7 = true;
                this.enabled = false;
            }

        }
    }

    void OnMouseDown()
    {
        if (tag == "molew" && scoreopen == true)
        {
            score.GetComponent<Score>().Scoretotal += 1;
            scoreopen = false;
        }
        if (tag == "moler" && scoreopen == true)
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
