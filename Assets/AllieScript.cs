using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllieScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float jumpStrength = 10;
    public LogicScript logic;
    

    // Start is called before the first frame update
    void Start()
    {
        //pipe middle script can find and talk to Logic Scipt now
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();

    }

    // Update is called once per frame
    void Update()
    {
        // to let ALLIE move UP
        if (Input.GetKeyDown(KeyCode.UpArrow) )
        {
            myRigidbody.velocity = Vector2.up * jumpStrength;
        }

        // to let ALLIE move DOWN
        if (Input.GetKeyDown(KeyCode.DownArrow) ) {
            myRigidbody.velocity = Vector2.down * jumpStrength;
        }

        // to let ALLIE move RIGHT
        if (Input.GetKeyDown(KeyCode.RightArrow) )
        {
            myRigidbody.velocity = Vector3.right * jumpStrength;
        }

        // to let ALLIE move LEFT
        if (Input.GetKeyDown(KeyCode.LeftArrow) )
        {
            myRigidbody.velocity = Vector3.left * jumpStrength;
        }
    }

  
}
