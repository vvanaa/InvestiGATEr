using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//trigger for inbtwn the pipes

public class PipeMiddleScript : MonoBehaviour
{
    public LogicScript logic; 

    void Start()
    {

        //pipe middle script can find and talk to Logic Scipt now
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>(); 
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision) {// for collider
        if(collision.gameObject.layer == 3) // layer 3 = layer allie
        {
            logic.addScore(1); // now only adds if collision w/ ALLIE only
            //allows us to make other stuff to add to score
            //for ex: add 5 to score once you answer the question of the special log
        }
    }
}
