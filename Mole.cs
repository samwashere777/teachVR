using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mole : MonoBehaviour
{
    // Show and Hide Variables
    public Score changeScore;
    public float VisibleYHeight = 1.3f;
    public float HiddenYHeight = -2.0f;
    private Vector3 myNewXYZPosition; // position to move Mole
    public float speed = 4f;          // speed the moles move
    public float hideMoleTimer = 1.25f;
    public bool hit = false;

    private void Awake()
    {
        HideMole();

        // set current position
        transform.localPosition = myNewXYZPosition;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Move mole to new position
        transform.localPosition = Vector3.Lerp(
            transform.localPosition, 
            myNewXYZPosition,
            Time.deltaTime * speed);

        // Hide Mole if timer less than 0
        hideMoleTimer -= Time.deltaTime;
        if (hideMoleTimer < 0)
        {
            HideMole();
        }
    }

    // hide the mole
    public void HideMole()
    {
        // Set current position to hidden
        myNewXYZPosition = new Vector3(
               transform.localPosition.x, 
               HiddenYHeight,
               transform.localPosition.z
        );
    }

    // show the mole
    public void ShowMole()
    {
        // Set current position to visible
        myNewXYZPosition = new Vector3(
               transform.localPosition.x,
               VisibleYHeight,
               transform.localPosition.z
        );

        // Reset the hideMoleTimer to 1.5 seconds before hiding
        hideMoleTimer = 1.25f;
    }

    void OnTriggerEnter(Collider other)
    {
        //gameManager.Disappear();
        HideMole();
        hit = true;
        //changeScore.moleHit = true;
        //changeScore.score += 20;
    }
}
