using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NameChangePopUpButton : MonoBehaviour
{
    [SerializeField] GameObject nameChangePopUp;

    public void PopUpNameChange()
    {
        nameChangePopUp.SetActive(true);
    }
}
