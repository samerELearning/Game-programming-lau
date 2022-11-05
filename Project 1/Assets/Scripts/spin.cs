using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spin : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print("Hello World!");
        
        Debug.Log(Vector3.up);
        Debug.Log($"Vector3.down: {Vector3.down}");

        Vector3 myVector1 = new Vector3(5.0f, 4.0f, 3.0f);
        Vector3 myVector2 = new Vector3(4.6f, 6.0f, 2.5f);
        Debug.Log(myVector1.magnitude);
        Debug.Log(Vector3.Distance(myVector1, myVector2));
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.left, 1);
    }
}
