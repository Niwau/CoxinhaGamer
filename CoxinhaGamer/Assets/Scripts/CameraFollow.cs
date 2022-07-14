using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public Rigidbody2D Target;

    void Update()
    {
        transform.position = new Vector3(Target.position.x, Target.position.y, transform.position.z);
    }
}
