using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerCtr : MonoBehaviour
{
    public Text timerText;
    public float Timer;
    // Start is called before the first frame update
    void Start()
    {
        timerText= GetComponent<Text>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Timer -= Time.deltaTime;
        timerText.text = Timer.ToString();
    }
}
