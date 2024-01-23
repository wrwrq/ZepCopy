using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum NameLimit
{
    MinName = 1, MaxName = 11
}

public class GameManager : MonoBehaviour
{
    public GameObject _player;
    [SerializeField] GameObject _settingNameCharacter;
    [SerializeField] GameObject viewCharacter;
    [SerializeField] GameObject GameUi;
    Camera _camera;
    public static GameManager gameManager;
    private void Awake()
    {
        if (gameManager == null)
        {
            gameManager = this;
            _camera = Camera.main;
        }
        else
        {
            Destroy(this);
        }
    }

    public void EndSetting(string name)
    {
        _settingNameCharacter.SetActive(false);
        _player.SetActive(true);
        _player.GetComponentInChildren<Text>().text = name;
        _camera.transform.SetParent(_player.transform);
        GameUi.SetActive(true);
    }
    public void SettingCharacter(PlayerAnima.Character cha)
    {
        _player.SetActive(true);
        _player.GetComponent<PlayerAnima>().CharacterChange(cha);
        viewCharacter.GetComponent<CharacterSelectButton>().ChangeImage(cha == PlayerAnima.Character.ad ? (int)PlayerAnima.Character.ad : (int)PlayerAnima.Character.nin);// ³ë´ä;
        if (_player.GetComponentInChildren<Camera>() == null)
        {
            _player.SetActive(false);
        }
    }
}
