using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseNameList : MonoBehaviour
{
    [SerializeField] GameObject namePanel;
    public void ClosenamePanel()
    {
        namePanel.SetActive(false);
    }
}
