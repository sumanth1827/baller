using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canva : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                StartCoroutine(tut());
            }
        }
    }
    IEnumerator tut()
    {
        yield return new WaitForSeconds(3f);
        Destroy(gameObject);
    }
}
