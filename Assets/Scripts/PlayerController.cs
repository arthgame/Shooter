using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public float speed;
    public Text countText;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up") && !GetComponent<Inventory>().IsFull())
        {
            GetComponent<Inventory>().PutItem(other.gameObject.GetComponent<Item>());
            other.gameObject.SetActive(false);
            countText.text = "Count: " + GetComponent<Inventory>().CountItems().ToString();
        }
    }
}
