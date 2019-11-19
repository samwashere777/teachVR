using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMesh UserScore;
    public GameObject mole1;
    public GameObject mole2;
    public GameObject mole3;
    public GameObject mole4;
    public GameObject mole5;
    public GameObject mole6;
    public GameObject mole7;
    public GameObject mole8;
    public GameObject mole9;
    private int score = 0;
    private bool moleHit = false;

    void Start()
    {
        UserScore.text = "Score: " + score;
    }
    // Update is called once per frame
    
    void Update()
    {
        if (mole1.GetComponent<Mole>().hit)
        {
            moleHit = true;
            mole1.GetComponent<Mole>().hit = false;
        }
        if (mole2.GetComponent<Mole>().hit)
        {
            moleHit = true;
            mole2.GetComponent<Mole>().hit = false;
        }
        if (mole3.GetComponent<Mole>().hit)
        {
            moleHit = true;
            mole3.GetComponent<Mole>().hit = false;
        }
        if (mole4.GetComponent<Mole>().hit)
        {
            moleHit = true;
            mole4.GetComponent<Mole>().hit = false;
        }
        if (mole5.GetComponent<Mole>().hit)
        {
            moleHit = true;
            mole5.GetComponent<Mole>().hit = false;
        }
        if (mole6.GetComponent<Mole>().hit)
        {
            moleHit = true;
            mole6.GetComponent<Mole>().hit = false;
        }
        if (mole7.GetComponent<Mole>().hit)
        {
            moleHit = true;
            mole7.GetComponent<Mole>().hit = false;
        }
        if (mole8.GetComponent<Mole>().hit)
        {
            moleHit = true;
            mole8.GetComponent<Mole>().hit = false;
        }
        if (mole9.GetComponent<Mole>().hit)
        {
            moleHit = true;
            mole9.GetComponent<Mole>().hit = false;
        }

        if (moleHit) {
            moleHit = false;
            score += 1;
        }
        UserScore.text = "Score: " + score;
    }
}
