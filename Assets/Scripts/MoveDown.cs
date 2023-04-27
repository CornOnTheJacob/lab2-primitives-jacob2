using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDown : MonoBehaviour
{
    private Rigidbody objectRb;
    private float zDestroy = -10.0f;

    public float speed = 2.5f;

    // Start is called before the first frame update
    void Start()
    {
        objectRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        objectRb.AddForce(Vector3.back * speed);
        if (transform.position.z < zDestroy)
        {
            Destroy(gameObject);
        }
    }
}
