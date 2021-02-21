using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeScript : MonoBehaviour
{

    private float timerCount;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      timerCount+=Time.deltaTime;  
      //Debug.Log(timerCount);
    }

    private void OnGUI(){
      GUIStyle style = new GUIStyle();
      style.normal.textColor = Color.black;
      GUI.Label(new Rect(10, 30, 400, 20), "Time elapsed: " + (int)timerCount + " seconds", style);
    }
}
