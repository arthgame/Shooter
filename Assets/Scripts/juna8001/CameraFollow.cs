using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class CameraFollow : MonoBehaviour {

    public Vector3 offSet;
    public Transform followed;

    void Update()
    {
        transform.position = followed.position + offSet;
    }
}
