using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 2.0f;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3( Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical") ) * speed * Time.deltaTime;
    }

}
