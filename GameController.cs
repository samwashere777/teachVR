using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    // Timer Variables
    public TextMesh timerText;      // Reference to our Unity Text
    public TextMesh createdBy;
    public float gameTimer = 30f;   // 30 second game timer
    public float restartGameTimer;  // Restarts after 4 seconds

    // Mole variables
    public GameObject moleContainer; // reference to our moleContainer in Unity
    private Mole[] moles;
    public float showMoleTimer = 1.5f; // show moles for 1.5 seconds

    // Hammer
    public GameObject hammer;

    // Start is called before the first frame update
    void Start()
    {
        // Put all moles into our list moles
        moles = moleContainer.GetComponentsInChildren<Mole>();

        //Debug.Log("Number of Moles: " + moles.Length);  // print moles to the screen
    }

    // Update is called once per frame
    void Update()
    {
        // update the game timer
        gameTimer -= Time.deltaTime; // subtracts a second from the game timer

        // Check that the game timer is greater than 0 seconds
        if (gameTimer > 0f)
        {
            // createdBy text
            createdBy.text = "Group 13 Test";

            // Update Timer
            timerText.text = "Whack-a-Mole: " + Mathf.Floor(gameTimer);

            // Show mole if == 0
            showMoleTimer -= Time.deltaTime;
            if (showMoleTimer < 0f)
            {
                // Show the next mole randomly then reset timer
                moles[Random.Range(0, moles.Length)].ShowMole();
                showMoleTimer = 1.5f;
            }
        }
        // Game timer < 0
        else
        {
            // Update text in Unity
            timerText.text = "Game Over";

            // Restart Game
            restartGameTimer -= Time.deltaTime;

            // Show restarting Time
            createdBy.text = "Restarting in " + restartGameTimer;

            // When restart game timer reaches 0, restart game
            if (restartGameTimer < 0)
            {
                gameTimer = 30f;
                restartGameTimer = 4f;
            }
        }
    }
}
