using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Dron : MonoBehaviour
{
    Rigidbody MyRigidBody;

    float Force = 4.0f;
    float Ver;
    float Hor;
    float Move;

    Vector3 newVector = new Vector3(0, 0, 1);
    void Start()
    {
        MyRigidBody = GetComponent<Rigidbody>();   
    }

    private void Update()
    {
        Ver = Input.GetAxis("Vertical");
        Hor = Input.GetAxis("Horizontal");
        Move = Input.GetAxis("Fire3");

        Debug.Log(Move);
    }
    void FixedUpdate()
    {
       
        MyRigidBody.AddRelativeForce(Force * newVector * (Move + 1));
        MyRigidBody.AddRelativeTorque(new Vector3(Ver, Hor, 0) * 1.0f);
    }
}
