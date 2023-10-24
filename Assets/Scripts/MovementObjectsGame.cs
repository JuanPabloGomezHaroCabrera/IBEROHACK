using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementObjectsGame : MonoBehaviour
{

    //Objects movement
    public float moveSpeed;
    public Transform endPoint;
    public Transform startPoint;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
        if (transform.position.x <= endPoint.position.x)
        {
            transform.position = new Vector3(startPoint.position.x, this.transform.position.y, this.transform.position.z);
        }
    }
}
