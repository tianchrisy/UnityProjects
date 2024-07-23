using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Dropper : MonoBehaviour
{
   [SerializeField] float timeDrop = 3f;
    MeshRenderer renderer; 
    Rigidbody rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<MeshRenderer>();
        renderer.enabled = false;
        rigidbody = GetComponent<Rigidbody>();
        rigidbody.useGravity = false;


    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(Time.time);
        if (Time.time > timeDrop)
        {
            rigidbody.useGravity = true;
            renderer.enabled = true;
            Debug.Log("3 seconds have past");
        }
    }
}
