using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneWayPlatform : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void OnTriggerStay(Collider collider)
    {
        float _velocity = collider.attachedRigidbody.velocity.y;
        if (_velocity < 0)
        {
            gameObject.GetComponent<Collider>().isTrigger = false;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        
    }
    void Update()
    {
        
    }
}
