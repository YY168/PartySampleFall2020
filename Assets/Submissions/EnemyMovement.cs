using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    // Start is called before the first frame update

    public float speed;
    public GameObject player1;
    public GameObject player2;
    public GameObject playerBase;
    public Transform pathStart;

    public Transform to;

    public Type target;
    public enum Type{
        Player1,
        Player2,
        Base,
        Both
    }

    void Start()
    {
        transform.position = pathStart.position;
        to = getNearest().transform;
    }

    // Update is called once per frame
    void Update()
    {
        to = getNearest().transform;
        transform.position = Vector3.MoveTowards(transform.position, to.position, speed * Time.deltaTime);
        if (transform.position == to.position) {
            Debug.Log("Reached Player1");
        }
    }

    private GameObject getNearest() 
    {
        switch (target) {
            case Type.Player1: {
                return player1;
            }
            case Type.Player2: {
                return player2;
            }
            case Type.Base: {
                return playerBase;
            }
            case Type.Both: {
                return player1;
            }
            default: {
                return null;
            }
        }
    }
}
