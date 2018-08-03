using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMole : MonoBehaviour {

    public GameObject Mole;
    public GameObject Mole1;
    public GameObject Mole2;
    public GameManerger gb;
    Vector2 randomhole;
    Vector2 hole1 = new Vector2(-3.97f, -3.87f);
    Vector2 hole2 = new Vector2(0f, -3.87f);
    Vector2 hole3 = new Vector2(4.07f, -3.87f);
    Vector2 hole4 = new Vector2(-3.97f, -0.87f);
    Vector2 hole5 = new Vector2(0f, -0.87f);
    Vector2 hole6 = new Vector2(4.07f, -0.87f);
    Vector2 hole7 = new Vector2(-3.97f, 2.04f);
    Vector2 hole8 = new Vector2(0f, 2.04f);
    Vector2 hole9 = new Vector2(4.07f, 2.04f);
    

    // Use this for initialization
    void Start () {
        InvokeRepeating("spawnMole", 0, 1f);
        //InvokeRepeating("spawnMole1", 0, 1f);
        //InvokeRepeating("spawnMole2", 0, 1f);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void spawnMole()
    {
        GameObject newMole = (GameObject)Instantiate(Mole);
        /*List<float> randomx = new List<float> { 0f, -3.97f,4.07f };
        List<float> randomy = new List<float> { 2.04f, -0.87f,-3.87f };
        float positionx = randomx[Random.Range(0, randomx.Count)];
        float positiony = randomy[Random.Range(0, randomx.Count)];*/
        if (gb.GetComponent<GameManerger>().openhole1 == false)
        {
            List<Vector2> randomholeex = new List<Vector2> {hole2, hole3, hole4, hole5, hole6, hole7, hole8, hole9 };
            randomhole = randomholeex[Random.Range(0, randomholeex.Count)];
            newMole.transform.position = randomhole;
        }
        else if (gb.GetComponent<GameManerger>().openhole2 == false)
        {
            List<Vector2> randomholeex = new List<Vector2> { hole1, hole3, hole4, hole5, hole6, hole7, hole8, hole9 };
            randomhole = randomholeex[Random.Range(0, randomholeex.Count)];
            newMole.transform.position = randomhole;
        }
        else if (gb.GetComponent<GameManerger>().openhole3 == false)
        {
            List<Vector2> randomholeex = new List<Vector2> { hole1, hole2, hole4, hole5, hole6, hole7, hole8, hole9 };
            randomhole = randomholeex[Random.Range(0, randomholeex.Count)];
            newMole.transform.position = randomhole;
        }
        else if (gb.GetComponent<GameManerger>().openhole4 == false)
        {
            List<Vector2> randomholeex = new List<Vector2> { hole1, hole2, hole3, hole5, hole6, hole7, hole8, hole9 };
            randomhole = randomholeex[Random.Range(0, randomholeex.Count)];
            newMole.transform.position = randomhole;
        }
        else if (gb.GetComponent<GameManerger>().openhole5 == false)
        {
            List<Vector2> randomholeex = new List<Vector2> { hole1, hole2, hole3, hole4, hole6, hole7, hole8, hole9 };
            randomhole = randomholeex[Random.Range(0, randomholeex.Count)];
            newMole.transform.position = randomhole;
        }
        else if (gb.GetComponent<GameManerger>().openhole6 == false)
        {
            List<Vector2> randomholeex = new List<Vector2> { hole1, hole2, hole3, hole4, hole5, hole7, hole8, hole9 };
            randomhole = randomholeex[Random.Range(0, randomholeex.Count)];
            newMole.transform.position = randomhole;
        }
        else if (gb.GetComponent<GameManerger>().openhole7 == false)
        {
            List<Vector2> randomholeex = new List<Vector2> { hole1, hole2, hole3, hole4, hole5, hole6, hole8, hole9 };
            randomhole = randomholeex[Random.Range(0, randomholeex.Count)];
            newMole.transform.position = randomhole;
        }
        else if (gb.GetComponent<GameManerger>().openhole8 == false)
        {
            List<Vector2> randomholeex = new List<Vector2> { hole1, hole2, hole3, hole4, hole5, hole6, hole7, hole9 };
            randomhole = randomholeex[Random.Range(0, randomholeex.Count)];
            newMole.transform.position = randomhole;
        }
        else if (gb.GetComponent<GameManerger>().openhole9 == false)
        {
            List<Vector2> randomholeex = new List<Vector2> { hole1, hole2, hole3, hole4, hole5, hole6, hole7, hole8 };
            randomhole = randomholeex[Random.Range(0, randomholeex.Count)];
            newMole.transform.position = randomhole;
        }
        else
        {
            List<Vector2> randomholeex = new List<Vector2> { hole1, hole2, hole3, hole4, hole5, hole6, hole7, hole8, hole9 };
            randomhole = randomholeex[Random.Range(0, randomholeex.Count)];
            newMole.transform.position = randomhole;
        }
        if (randomhole == hole1)
        {
            gb.GetComponent<GameManerger>().openhole1 = false;
        }
        if (randomhole == hole2)
        {
            gb.GetComponent<GameManerger>().openhole2 = false;
        }
        if (randomhole == hole3)
        {
            gb.GetComponent<GameManerger>().openhole3 = false;
        }
        if (randomhole == hole4)
        {
            gb.GetComponent<GameManerger>().openhole4 = false;
        }
        if (randomhole == hole5)
        {
            gb.GetComponent<GameManerger>().openhole5 = false;
        }
        if (randomhole == hole6)
        {
            gb.GetComponent<GameManerger>().openhole6 = false;
        }
        if (randomhole == hole7)
        {
            gb.GetComponent<GameManerger>().openhole7 = false;
        }
        if (randomhole == hole8)
        {
            gb.GetComponent<GameManerger>().openhole8 = false;
        }
        if (randomhole == hole9)
        {
            gb.GetComponent<GameManerger>().openhole9 = false;
        }
    }
    void spawnMole1()
    {
        GameObject newMole1 = (GameObject)Instantiate(Mole1);
        /*List<float> randomx = new List<float> { 0f, -3.97f,4.07f };
         List<float> randomy = new List<float> { 2.04f, -0.87f,-3.87f };
         float positionx = randomx[Random.Range(0, randomx.Count)];
         float positiony = randomy[Random.Range(0, randomx.Count)];*/
        List<Vector2> randomholeex = new List<Vector2> { hole1, hole2, hole3, hole4, hole5, hole6, hole7, hole8, hole9 };
        Vector2 randomhole = randomholeex[Random.Range(0, randomholeex.Count)];
        newMole1.transform.position = randomhole;
    }
    void spawnMole2()
    {
        GameObject newMole2 = (GameObject)Instantiate(Mole2);
        /*List<float> randomx = new List<float> { 0f, -3.97f,4.07f };
        List<float> randomy = new List<float> { 2.04f, -0.87f,-3.87f };
        float positionx = randomx[Random.Range(0, randomx.Count)];
        float positiony = randomy[Random.Range(0, randomx.Count)];*/
        List<Vector2> randomholeex = new List<Vector2> { hole1, hole2, hole3, hole4, hole5, hole6, hole7, hole8, hole9 };
        Vector2 randomhole = randomholeex[Random.Range(0, randomholeex.Count)];
        newMole2.transform.position = randomhole;
    }
}
