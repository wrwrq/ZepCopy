using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserListButton : MonoBehaviour
{
    [SerializeField] GameObject userListPanel;

    public void OnUserList()
    {
        userListPanel.SetActive(true);
    }
}
