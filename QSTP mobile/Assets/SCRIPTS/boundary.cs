using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class boundary : MonoBehaviour
{
    [SerializeField] Transform portal;
    private void OnTriggerEnter(Collider ci)
    {
        if (ci.tag == "Player")
        {
            ci.transform.position = portal.position;
            
        }
    }

}
