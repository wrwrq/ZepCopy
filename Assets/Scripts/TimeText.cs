using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeText : MonoBehaviour
{
    private void Update()
    {
        GetComponent<Text>().text = DateTime.Now.ToString("HH:mm");
    }
}
