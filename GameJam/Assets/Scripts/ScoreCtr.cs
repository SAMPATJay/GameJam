using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCtr : MonoBehaviour
{
    public Text scr;
    public int score;
    // Start is called before the first frame update
    void Start()
    {
        scr = GetComponent<Text>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        scr.text = (score).ToString();
    }
}
