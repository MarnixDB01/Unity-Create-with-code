using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBoundary = 30.0f;
    private float lowerBoundary = -10.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //If an object goes past the players view in the game, remove that object.
        if (transform.position.z > topBoundary)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBoundary)
        {
            Debug.Log("Game Over!");
            Destroy(gameObject);
        }
    }
}
