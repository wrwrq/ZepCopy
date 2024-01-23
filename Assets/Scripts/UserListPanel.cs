using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class UserListPanel : MonoBehaviour
{
    [SerializeField] Text nameListtext;
    static List<Text> texts = new List<Text>();
    int UnitCount;
    private void Awake()
    {
        UnitCount = NpcList.npcs.Count + 1;
    }
    private void Update()
    {
        UnitCount = NpcList.npcs.Count + 1;
        if (UnitCount < texts.Count)
        {
            for (int i = texts.Count; i > UnitCount; i--)
            {
                texts[i - 1].transform.gameObject.SetActive(false);
            }
        }
        else if (UnitCount > texts.Count)
        {
            for (int i = texts.Count; i < UnitCount; i++)
            {
                Text tempText = Instantiate(nameListtext, this.transform.position, Quaternion.identity, this.transform);
                texts.Add(tempText);
            }
        }
        SetNameText();
    }
    void SetNameText()
    {
        for (int i = 0; i < UnitCount; i++)
        {
            texts[i].transform.gameObject.SetActive(true);
            if (i == 0)
            {
                texts[i].text = GameManager.gameManager._player.GetComponentInChildren<Text>().text;
                continue;
            }
            texts[i].text = NpcList.npcs[i - 1]._name;
        }
    }
    public static void ReSetPlayerName()
    {
        if (texts.Count == 0)
        {
            return;
        }
        texts[0].text = GameManager.gameManager._player.GetComponentInChildren<Text>().text;
    }
}
