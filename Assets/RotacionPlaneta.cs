using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotacionPlaneta : MonoBehaviour
{
    float velAngular;
    // Start is called before the first frame update
    void Start()
    {
        velAngular = Random.Range(-45, 45);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, velAngular * Time.deltaTime, 0);
    }
}
