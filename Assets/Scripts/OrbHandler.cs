using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbHandler : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
}
