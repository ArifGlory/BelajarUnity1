using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    Rigidbody rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    
    // Start is called before the first frame update
    void Start()
    {
        //rb.useGravity = false;
        //transform.position = new Vector3(15, transform.position.y, transform.position.z);
        //Invoke("MoveCube", 2);
        StartCoroutine(MoveCubeCoroutine());
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * 5 * Time.deltaTime);
        //transform.Rotate(Vector3.up * 30 * Time.deltaTime); 
    }

    void MoveCube()
    {
        transform.position = new Vector3(15, transform.position.y, transform.position.z);
    }

    IEnumerator MoveCubeCoroutine()
    {
        yield return new WaitForSeconds(2);
        transform.position = new Vector3(15, transform.position.y, transform.position.z);

        yield return new WaitForSeconds(3);
        transform.position = new Vector3(0, transform.position.y, transform.position.z);
    }
}
