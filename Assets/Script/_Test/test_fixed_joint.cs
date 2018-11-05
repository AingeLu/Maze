using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test_fixed_joint : MonoBehaviour
{

    Quaternion quaternion;

    Rigidbody body;
    // Use this for initialization
    void Start()
    {
        quaternion = transform.rotation;
        this.body = this.GetComponent<Rigidbody>();
        this.body.AddForce(new Vector3(0, 0, 100));//给它一个z轴方向的力
    }

    // Update is called once per frame
    void Update()
    {
        quaternion = transform.rotation;
    }
}
