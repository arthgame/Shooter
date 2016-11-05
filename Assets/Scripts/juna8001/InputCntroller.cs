using UnityEngine;
using System.Collections;

public class InputCntroller : MonoBehaviour {

    IMovement movement;

    void Start()
    {
        movement = GetComponent<IMovement>();
    }

    void Update()
    {
        movement.Direction = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
    }

}
