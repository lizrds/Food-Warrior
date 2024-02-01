using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slicer : MonoBehaviour
{
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>(); 
    }

    // Update is called once per frame
    void Update()
    {
        var worldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = worldPos;

        worldPos.z = 0;
        rb.MovePosition(worldPos);
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
    }
}
