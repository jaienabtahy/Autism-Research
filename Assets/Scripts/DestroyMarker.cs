using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyMarker : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
            Destroy(gameObject);
    }
}
