using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour
{
    Vector3 newPosition;
    private Brick brick;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        brick = GameObject.FindObjectOfType<Brick>();
        transform.position = Vector3.MoveTowards(transform.position, brick.transform.position, 0.02f);
    }
}
