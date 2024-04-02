using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PressurePlate : MonoBehaviour
{
    public TMP_Text pressureNumber;
    private float collisionMagnitude;
    private float value;

    // Start is called before the first frame update
    void Start()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        pressureNumber.text = "0";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision) 
    {
        collisionMagnitude = collision.relativeVelocity.magnitude / 1.7f;

        if (collisionMagnitude > 0) {
            value = 0;
        }
        if (collisionMagnitude > 1) {
            value = 1;
        }
        if (collisionMagnitude > 2) {
            value = 2;
        }
        if (collisionMagnitude > 3) {
            value = 3;
        }
        if (collisionMagnitude > 4) {
            value = 4;
        }
        if (collisionMagnitude > 5) {
            value = 5;
        }
        if (collisionMagnitude > 6) {
            value = 6;
        }
        if (collisionMagnitude > 7) {
            value = 7;
        }
        if (collisionMagnitude > 8) {
            value = 8;
        }
        if (collisionMagnitude > 9) {
            value = 9;
        }

        pressureNumber.text = value.ToString();
    }
}
