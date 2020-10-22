using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Rigidbody2D rigidbody2D;
    public float speed = 1;
    public bool move = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space)) {
            if (!move) {
                move = true;
            } else {
                move = false;
                transform.position = new Vector3(0,0,0);
            }
        }
        if (move) {
            transform.position = transform.position + new Vector3(1,0,0) * speed * Time.deltaTime;
        }  
    }
}
