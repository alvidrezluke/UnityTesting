using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float moveSpeed;

    private Vector3 input;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        input = new Vector3(input.getAxis("Horizontal"), 0, input.getAxis("Vertical"));
        GetComponent<Rigidbody>("Player").addForce(input * moveSpeed);
    }
}
