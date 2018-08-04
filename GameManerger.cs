using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManerger : MonoBehaviour
{

    //red mole*9 white mole*9
    public GameObject Molew;
    public GameObject Moler;
    public GameObject Molew1;
    public GameObject Moler1;
    public GameObject Molew2;
    public GameObject Moler2;
    public GameObject Molew3;
    public GameObject Moler3;
    public GameObject Molew4;
    public GameObject Moler4;
    public GameObject Molew5;
    public GameObject Moler5;
    public GameObject Molew6;
    public GameObject Moler6;
    public GameObject Molew7;
    public GameObject Moler7;
    public GameObject Molew8;
    public GameObject Moler8;
    public GameObject Timer;


   
    GameObject gamemaneger;
    //choose a random mole when openhole is true
    public bool open= true;
    public bool openhole1 = true;
    public bool openhole2 = true;
    public bool openhole3 = true;
    public bool openhole4 = true;
    public bool openhole5 = true;
    public bool openhole6 = true;
    public bool openhole7 = true;
    public bool openhole8 = true;
    public bool openhole9 = true;
    //mole goes up when molespeed is true
    public bool molespeed = true;
    public bool molespeed1 = true;
    public bool molespeed2 = true;
    public bool molespeed3 = true;
    public bool molespeed4 = true;
    public bool molespeed5 = true;
    public bool molespeed6 = true;
    public bool molespeed7 = true;
    public bool molespeed8 = true;


    // Use this for initialization
    void Start()
    {
        //repeat to choose randomMole
        InvokeRepeating("RandomMole", 0,1);
        InvokeRepeating("RandomMole1", 0, 1);
        InvokeRepeating("RandomMole2", 0, 1);
        InvokeRepeating("RandomMole3", 0, 1);
        InvokeRepeating("RandomMole4", 0, 1);
        InvokeRepeating("RandomMole5", 0, 1);
        InvokeRepeating("RandomMole6", 0, 1);
        InvokeRepeating("RandomMole7", 0, 1);
        InvokeRepeating("RandomMole8", 0, 1);

    }

    // Update is called once per frame
    void Update()
    {

    }
    void RandomMole()
    {
        //when openhole is true 
        if (open == true)
        {
            //choose white(0) or red(1) mole 
            int RandMoleNumber = Random.Range(0, 2);
            if (RandMoleNumber == 0)
            {

                molespeed = true;//molespeed is true then mole can go up
                Molew.GetComponent<Moving>().scoreopen = true;//when scoreopen is true then can add points
                Molew.GetComponent<Moving>().enabled = true;//moving script is enable;
               

            }
            else if (RandMoleNumber == 1)
            {
                molespeed = true;
                Moler.GetComponent<Moving>().scoreopen = true;
                Moler.GetComponent<Moving>().enabled = true;
            }
        }
    }
    void RandomMole1()
    {
        if (openhole1 == true && Timer.GetComponent<Timer>().timing>0)
        {
            int RandMoleNumber1 = Random.Range(0, 2);
            if (RandMoleNumber1 == 0)
            {
                molespeed1 = true;
                Molew1.GetComponent<Moving1>().scoreopen = true;
                Molew1.GetComponent<Moving1>().enabled = true;
            }
            else if (RandMoleNumber1 == 1)
            {
                molespeed1 = true;
                Moler1.GetComponent<Moving1>().scoreopen = true;
                Moler1.GetComponent<Moving1>().enabled = true;
            }
        }
    }
    void RandomMole2()
    {
        if (openhole2 == true && Timer.GetComponent<Timer>().timing>0)
        {
            int RandMoleNumber2 = Random.Range(0, 2);
            if (RandMoleNumber2 == 0)
            {
                molespeed2 = true;
                Molew2.GetComponent<Moving2>().scoreopen = true;
                Molew2.GetComponent<Moving2>().enabled = true;
            }
            else if (RandMoleNumber2 == 1)
            {
                molespeed2 = true;
                Moler2.GetComponent<Moving2>().scoreopen = true;
                Moler2.GetComponent<Moving2>().enabled = true;
            }
        }
    }
    void RandomMole3()
    {
        if (openhole3 == true && Timer.GetComponent<Timer>().timing>0)
        {
            int RandMoleNumber3 = Random.Range(0, 2);
            if (RandMoleNumber3 == 0)
            {
                molespeed3 = true;
                Molew3.GetComponent<Moving3>().scoreopen = true;
                Molew3.GetComponent<Moving3>().enabled = true;
            }
            else if (RandMoleNumber3 == 1)
            {
                molespeed3 = true;
                Moler3.GetComponent<Moving3>().scoreopen = true;
                Moler3.GetComponent<Moving3>().enabled = true;
            }
        }
    }
    void RandomMole4()
    {
        if (openhole4 == true && Timer.GetComponent<Timer>().timing>0)
        {
            int RandMoleNumber4 = Random.Range(0, 2);
            if (RandMoleNumber4 == 0)
            {
                molespeed4 = true;
                Molew4.GetComponent<Moving4>().scoreopen = true;
                Molew4.GetComponent<Moving4>().enabled = true;
            }
            else if (RandMoleNumber4 == 1)
            {
                molespeed4 = true;
                Moler4.GetComponent<Moving4>().scoreopen = true;
                Moler4.GetComponent<Moving4>().enabled = true;
            }
        }
    }
    void RandomMole5()
    {
        if (openhole5 == true && Timer.GetComponent<Timer>().timing>0)
        {
            int RandMoleNumber5 = Random.Range(0, 2);
            if (RandMoleNumber5 == 0)
            {
                molespeed5 = true;
                Molew5.GetComponent<Moving5>().scoreopen = true;
                Molew5.GetComponent<Moving5>().enabled = true;
            }
            else if (RandMoleNumber5 == 1)
            {
                molespeed5 = true;
                Moler5.GetComponent<Moving5>().scoreopen = true;
                Moler5.GetComponent<Moving5>().enabled = true;
            }
        }
    }
    void RandomMole6()
    {
        if (openhole6 == true && Timer.GetComponent<Timer>().timing>0)
        {
            int RandMoleNumber6 = Random.Range(0, 2);
            if (RandMoleNumber6 == 0)
            {
                molespeed6 = true;
                Molew6.GetComponent<Moving6>().scoreopen = true;
                Molew6.GetComponent<Moving6>().enabled = true;
            }
            else if (RandMoleNumber6 == 1)
            {
                molespeed6 = true;
                Moler6.GetComponent<Moving6>().scoreopen = true;
                Moler6.GetComponent<Moving6>().enabled = true;
            }
        }
    }
    void RandomMole7()
    {
        if (openhole7 == true && Timer.GetComponent<Timer>().timing>0)
        {
            int RandMoleNumber7 = Random.Range(0, 2);
            if (RandMoleNumber7 == 0)
            {
                molespeed7 = true;
                Molew7.GetComponent<Moving7>().scoreopen = true;
                Molew7.GetComponent<Moving7>().enabled = true;
            }
            else if (RandMoleNumber7 == 1)
            {
                molespeed7 = true;
                Moler7.GetComponent<Moving7>().scoreopen = true;
                Moler7.GetComponent<Moving7>().enabled = true;
            }
        }
    }
    void RandomMole8()
    {
        if (openhole8 == true && Timer.GetComponent<Timer>().timing>0)
        {
            int RandMoleNumber8 = Random.Range(0, 2);
            if (RandMoleNumber8 == 0)
            {
                molespeed8 = true;
                Molew8.GetComponent<Moving8>().scoreopen = true;
                Molew8.GetComponent<Moving8>().enabled = true;
            }
            else if (RandMoleNumber8 == 1)
            {
                molespeed8 = true;
                Moler8.GetComponent<Moving8>().scoreopen = true;
                Moler8.GetComponent<Moving8>().enabled = true;
            }
        }
    }
    
}
