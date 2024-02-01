using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject fruit;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating(nameof(Spawn), 1f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Spawn()
    {
        var obj = Instantiate(fruit);
        obj.transform.position = new Vector3(0, 0, 1);
    }
}
