using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BurdController : MonoBehaviour
{
    public float flappingStrngth = 100.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
            gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up * flappingStrngth);
        }
    }
    void OnCollisionEnter (Collision other)
    {
        if (other.gameObject.tag == "Ground")
        {
            Application.LoadLevel("FlappyBird");
        }
        if (other.gameObject.tag == "Pipe")
        {
            Application.LoadLevel("FlappyBird");
        }
    }
}
