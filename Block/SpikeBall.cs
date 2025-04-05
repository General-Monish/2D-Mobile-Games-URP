using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeBall : MonoBehaviour
{
    [SerializeField] float rotateAngel = 90f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RotateSpike();
    }

    void RotateSpike()
    {
        transform.Rotate(Vector3.forward, rotateAngel * Time.deltaTime);
    }
}
