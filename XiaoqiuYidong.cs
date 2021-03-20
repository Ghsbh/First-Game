using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YiDong : MonoBehaviour
{
    private Rigidbody rg;
    private Transform tr;
    // Start is called before the first frame update
    void Start()
    {
        rg = GetComponent<Rigidbody>();
        tr = GetComponent<Transform>();        
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Vector3 n = new Vector3(-h, 0, -v);
        rg.AddForce(n);
    }
}
