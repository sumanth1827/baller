using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class next : MonoBehaviour
{
    public float abc = 0f;
    public float t = 10f;
    private float duration = 1f;
    public bool ab = false;
    [SerializeField] private Vector3 endpos,a;
    public GameObject portal;

    private void Start()
    {
        a = Camera.main.transform.position;
    }
    void Update()
    {
        



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
                            a = Camera.main.transform.position;
                            endpos.y = a.y - 19f;
                            endpos.x = a.x;
                            endpos.z = a.z;
                            ab = true;
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
        a = Camera.main.transform.position;
        endpos.y = a.y - 19f;
        endpos.x = a.x;
        endpos.z = a.z;
        ab = true;
        

    }
}
