using UnityEngine;
using System.Collections;

public class InputController : MonoBehaviour {

    public Transform cursor;
    public LayerMask groundMask;

    IMovement movement;

    void Start()
    {
        movement = GetComponent<IMovement>();
    }

    void Update()
    {
        movement.Direction = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        moveCursor();
        float angle = Vector3.Angle(Vector3.forward, new Vector3(cursor.position.x - transform.position.x, 0, cursor.position.z - transform.position.z));
        if (cursor.position.x < transform.position.x)
            angle = 360 - angle;
        movement.Rotation = angle;
    }

    void moveCursor()
    {
        Ray r = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit[] hits = Physics.RaycastAll(r, Mathf.Infinity, groundMask);
        cursor.position = hits[0].point;
    }

}
