using UnityEngine;
using System.Collections;

public class PlayerMov : MonoBehaviour {

    public float speed = 8f;
     
    void Start()
    {
        //lock the state of cursor, turn off cursor and 
        //won't see it on the screen. It will stay 
        //inside the game window.
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            Cursor.lockState = CursorLockMode.None;
        }

        float translation = Input.GetAxis("Vertical") * speed;
        //side movements
        float straffe = Input.GetAxis("Horizontal")/4;

        translation *= Time.deltaTime;

        transform.Translate(straffe, 0, translation);
    }
}
