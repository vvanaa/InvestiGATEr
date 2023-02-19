using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipeSpawnScript : MonoBehaviour
{
    public GameObject Pipe; // refernece to the pipe object we made
    
    public float spawnRate = 2; //write code to make a timer using two variables 
    private float timer = 0;//write code to make a timer using two variables

    public float heightOffset = 5; // to make pipes go at diff heights 

    // Start is called before the first frame update
    void Start()
    {
        spawnPipe(); 
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate) {
            timer += Time.deltaTime; //count time up
            //delatTime is to make game in all types of computers be the same
        }
        else {
            spawnPipe();
            timer = 0; // reset timer
        }
        
    }

    void spawnPipe() {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;

        // Debug.Log("here");
        //make pipe show up at random y values but same x value (pipes at different heights)
        Instantiate(Pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
    }
}
