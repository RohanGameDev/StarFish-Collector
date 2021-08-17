using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscillator : MonoBehaviour
{
    float movementFactor;
    public Vector3 movementVector;
    Vector3 startingPosition;
    [SerializeField] float period = 2f;


    // Start is called before the first frame update
    void Start()
    {
        startingPosition = transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (period == 0)
        {
            return;
        }
        float cycles = Time.time / period; //continually growing over time

        const float tau = Mathf.PI * 2;    //constant value of tau
        movementFactor = Mathf.Sin(cycles * tau); // going from -1 to 1

       // movementFactor = (rawSinwave + 1f) / 2; //recalculated to go from 0 to 1

        Vector3 offset = movementVector * movementFactor;
        transform.position = startingPosition + offset;
    }
}
