using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TouchControl : MonoBehaviour
{
    public LayerMask enemyLayer;
    Touch t;
    private void Awake()
    {
        
    }

    void Start()
    {
        
    }
    void FixedUpdate()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity, enemyLayer))
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.cyan);
            Debug.Log(hit.transform.name);
        }
        else
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 1000, Color.gray);
            Debug.Log("hedef YOK");
        }

        //Vector3 dir = Vector3.zero;
        //dir.x = -Input.acceleration.y;
        //dir.z = -Input.acceleration.x;

        //if (dir.sqrMagnitude > 1)
        //{
        //    dir.Normalize();
        //    dir *= Time.deltaTime;
        //    transform.Translate(dir * 20);
        //}
    }
    public void Exit()
    {
        Application.Quit();
    }

}
