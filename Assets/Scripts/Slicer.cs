using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slicer : MonoBehaviour
{
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); 
    }

    // Update is called once per frame
    void Update()
    {
        var worldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = worldPos;

        worldPos.z = 2;
        rb.MovePosition(worldPos);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(collision.gameObject);
        print("yes");
    }
}
