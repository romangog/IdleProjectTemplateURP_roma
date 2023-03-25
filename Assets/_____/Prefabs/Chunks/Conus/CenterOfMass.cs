using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CenterOfMass : MonoBehaviour
{
    [SerializeField] private Vector3 _centerOfMass;
    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<Rigidbody>().centerOfMass = _centerOfMass;
    }
}
