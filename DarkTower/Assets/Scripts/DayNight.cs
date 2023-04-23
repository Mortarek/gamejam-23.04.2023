using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;



public class DayNight : MonoBehaviour
{
    public Animator panelGameOverAnim;
    public Text gameScore;
    public Text menuScore;

    public Volume ppv;
    public float seconds;
    public GameObject player;
    public void GameOver()
    {
        GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>().enabled = false;
        panelGameOverAnim.SetTrigger("Open");
        menuScore.text = gameScore.text;
        gameScore.gameObject.SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
    {
        ppv = gameObject.GetComponent<Volume>();
        
    }

    private void Update()
    {
        if (seconds >= 2)
        {
            if (Input.GetKeyDown(KeyCode.X))
            {
                seconds -= 1;
            }
        }
    }
    void FixedUpdate()
    {
        CalcTime();
        
    }

    public void CalcTime()
    {
        seconds += Time.fixedDeltaTime;
        if (seconds > 1 && seconds < 4)
        {
            ppv.weight = (float)seconds / 10;
        }
        if (seconds > 2 && seconds < 6)
        {
            ppv.weight = (float)seconds / 10;
        }
        if (seconds > 3 && seconds < 8)
        {
            ppv.weight = (float)seconds / 10;
        }
        if (seconds > 4 && seconds < 10)
        {
            ppv.weight = (float)seconds / 10;
        }
        if (seconds > 5 && seconds < 12)
        {
            ppv.weight = (float)seconds / 10;
        }
        if (seconds > 6 && seconds < 14)
        {
            ppv.weight = (float)seconds / 10;
        }
        if (seconds > 7 && seconds < 16)
        {
            ppv.weight = (float)seconds / 10;
        }
        if (seconds > 8 && seconds < 18)
        {
            ppv.weight = (float)seconds / 10;
        }
        if (seconds > 9 && seconds < 20)
        {
            ppv.weight = (float)seconds / 10;
        }



        if (seconds >= 20)
        {
            seconds = 20;
        }

        


        if (ppv.weight >= 0.99f)
        {
            Destroy(player);
            GameOver();
        }
    }
    



}
