using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TranslacionPlaneta : MonoBehaviour
{
    float velAngular;
    // Start is called before the first frame update
    void Start()
    {
        velAngular = Random.Range(-80, 80);
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(Vector3.zero, Vector3.up, velAngular* Time.deltaTime);
    }
}
