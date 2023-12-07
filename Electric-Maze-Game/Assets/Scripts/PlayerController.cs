using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 5;

    private float distanceX, distanceY;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!End.endState && Accident.health > 0)  
        {
            distanceX = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
            distanceY = Input.GetAxis("Vertical") * Time.deltaTime * speed;
            
            transform.Translate(distanceX, distanceY, 0);
        }
        else if (Accident.health > 0 )  
        {
            transform.Translate(0, -0.3f * Time.deltaTime, 0);
        }
        
        
    }
}
