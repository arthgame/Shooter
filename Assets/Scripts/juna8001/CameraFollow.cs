using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

    public Vector3 offSet;
    public Transform followed;

    void FixedUpdate()
    {
        transform.position = followed.position + offSet;
    }
}
