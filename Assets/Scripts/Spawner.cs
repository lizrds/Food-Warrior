using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject fruit;
    public int spawn;
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
        spawn = Random.Range(-3, 3);
        var obj = Instantiate(fruit);
        obj.transform.position = new Vector3(spawn, 0, 2);
        print(spawn.ToString());
    }
}
