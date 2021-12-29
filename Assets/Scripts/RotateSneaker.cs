using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RotateSneaker : MonoBehaviour
{
    public Vector3 editRotation;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        //Rotate on press of r key
        if (Input.GetKey("r"))
            {
                transform.Rotate(editRotation * Time.deltaTime);
                Debug.Log("Update");
            }
        

    }
}
