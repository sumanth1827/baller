using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class score : MonoBehaviour
{
    public int level;
    public float scores;
    public int deaths=0;
    public static int actdeath;
    [SerializeField] TMP_Text lvl, sco, dth;
    [SerializeField] Image a1, a2, a3;
    void Start()
    {
        level = SceneManager.GetActiveScene().buildIndex + 1;
        lvl.text = level.ToString();
        scores = 300f;
    }
    private void Awake()
    {
        deaths = actdeath;
    }
    // Update is called once per frame
    void Update()
    {
        actdeath = deaths;
    dth.text = deaths.ToString();
        scores -= Time.deltaTime;
        sco.text = scores.ToString("F2");
        if(scores<200)
        {
            Destroy(a3);

        }
        if(scores<100)
        {
            Destroy(a2);
        }
        if(scores <25)
        {
            Destroy(a1);
        }
}
}
