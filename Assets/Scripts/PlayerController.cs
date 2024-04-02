using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 5000f;
    private Rigidbody rb;
    private GameObject focalPoint;
    private GameObject door1;
    public bool isUnlocked = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        focalPoint = GameObject.Find("Focal Point");
        door1 = GameObject.Find("Door1");
    }

    // Update is called once per frame
    void Update()
    {
        float ver = Input.GetAxis("Vertical");

        rb.AddForce(focalPoint.transform.forward * ver * speed * Time.deltaTime); 

        if (isUnlocked == true) {
            door1.transform.position = new Vector3(0, -4, 0);
        }
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Button"))
        {
            isUnlocked = true;
        }
    }
}