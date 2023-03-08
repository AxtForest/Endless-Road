using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField]
    private Rigidbody rg;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rg.AddForce(new Vector3(0, 0, 1f));
    }
}
