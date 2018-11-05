using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test_hinge_joint : MonoBehaviour
{
    private Rigidbody body;

    // Use this for initialization
	void Start ()
    {
        this.body = this.GetComponent<Rigidbody>();
        this.body.AddForce(new Vector3(100, 0, 0));//给一个z轴方向的力
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
