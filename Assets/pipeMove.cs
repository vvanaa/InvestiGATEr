using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipeMove : MonoBehaviour
{
    public float moveSpeed = 5; //speed
    public float deadZone = -28; //off screen zone 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;
        //delta time keeps logs from ZOOMING
        if (transform.position.x < deadZone)//if clone in the dead zone 
        {
            // Debug.Log("pipe deleted");
            Destroy(gameObject); //KILL THE CLONE AHHHH!!!!!!!!!!!!!!!
        }
        
    }
}
