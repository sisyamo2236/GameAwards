using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("‘¬“x")]
    [Range(0, 50), SerializeField] float speed; //‘¬“x
    //[Header("‰ñ“]‘¬“x")]
    //[Range(0, 50), SerializeField] float smooth; //‰ñ“]‘¬“x

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 position = transform.position;

        if (Input.GetKey("left"))
        {
            position.x -= speed * Time.deltaTime;
        }
        else if (Input.GetKey("right"))
        {
            position.x += speed * Time.deltaTime;
        }
        else if (Input.GetKey("up"))
        {
            position.y += speed * Time.deltaTime;
        }
        else if (Input.GetKey("down"))
        {
            position.y -= speed * Time.deltaTime;
        }

        transform.position = position;
    }
}
