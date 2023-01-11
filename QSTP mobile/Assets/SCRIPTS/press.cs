using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class press : MonoBehaviour
{
    public float abc = 0f;
    public Vector3 touchpos1;
  

 
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            if (Input.touchCount > 0)
            {

                Touch touch = Input.GetTouch(0);

                Vector3 touchPosition = Camera.main.ScreenToWorldPoint(new Vector3(touch.position.x, touch.position.y, abc));
                Vector3 actualtouchpos = new Vector3(touchPosition.x, touchPosition.y, abc);

                touchpos1 = actualtouchpos;
                if (touch.phase == TouchPhase.Began)
                {


                    Collider[] touchcollider = Physics.OverlapSphere(actualtouchpos, 0.4f);
                    for (int i = 0; i < touchcollider.Length; i++)
                    {
                        if (touchcollider[i].tag == "Player")
                        {

                            
                            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

                        }
                      
                      

                    }

                }
               
            }
        }
    }
}
