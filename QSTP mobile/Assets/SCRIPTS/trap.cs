using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class trap : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision ci)
    {
        if(ci.gameObject.tag == "Player")
        {
           
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
