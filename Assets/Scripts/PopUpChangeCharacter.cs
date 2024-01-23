using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUpChangeCharacter : MonoBehaviour
{
    [SerializeField] GameObject ChangeCharacterPanel;
    public void PopUpCharacterPanel()
    {
        ChangeCharacterPanel.SetActive(true);
    }
}
