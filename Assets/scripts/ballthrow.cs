using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballthrow : MonoBehaviour
{
    public float forces = 200f;
    public Vector3 p;
    public Transform t;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //		if (Input.GetMouseButtonDown (1)) {
        //			
        //			Vector3 a=Input.mousePosition;
        //			this.GetComponent<Rigidbody> ().AddForce(transform.forward*a.x*forces);
        //			this.GetComponent<Rigidbody> ().transform.Rotate (45,0,0,  Space.World);
        //		
        //
        //		}
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Input.GetMouseButtonDown(1))
        {
            if (Physics.Raycast(ray, out hit, 100))
            {
                Debug.Log("IM hit");
                p = hit.point;
                t.position = hit.point;
            }
        }

    }



}
