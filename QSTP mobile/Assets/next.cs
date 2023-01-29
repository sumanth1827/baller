using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class next : MonoBehaviour
{
    public float abc = 0f;
    public float t = 10f;
    private float duration = 1f;
    public bool ab = false;
    private Vector3 startpos,endpos,a;
    public GameObject portal;

   
    void Update()
    {


        startpos = Camera.main.transform.position;


        if (ab)
        {

            t += Time.deltaTime;
            Camera.main.transform.position = Vector3.Lerp(a, endpos, t/duration);


        }
       
       
    }
    private void OnTriggerStay(Collider ci)
    {
        if (ci.tag == "Player")
        {
            if (Input.touchCount > 0)
            {

                Touch touch = Input.GetTouch(0);

                Vector3 touchPosition = Camera.main.ScreenToWorldPoint(new Vector3(touch.position.x, touch.position.y, abc));
                Vector3 actualtouchpos = new Vector3(touchPosition.x, touchPosition.y, abc);

                
                if (touch.phase == TouchPhase.Began)
                {


                    Collider[] touchcollider = Physics.OverlapSphere(actualtouchpos, 0.4f);

                    for (int i = 0; i < touchcollider.Length; i++)
                    {
                        if (touchcollider[i].tag == "Player")
                        {
                            tester();
                            ci.transform.position = portal.transform.position;
                            
                        }



                    }

                }

            }
        }
    }
    private void tester()
    {
        Debug.Log("activated");
        a = startpos;
        endpos.y = startpos.y - 19f;
        endpos.x = startpos.x;
        endpos.z = startpos.z;
        ab = true;
        

    }
}
