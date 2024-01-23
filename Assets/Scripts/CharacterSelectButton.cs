using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterSelectButton : MonoBehaviour
{
    [SerializeField] GameObject _selectCharacterPanel;
    [SerializeField] List<Sprite> _image = new List<Sprite>();
    [SerializeField] Image _viewImage;
    public void StartSelectCharacter()
    {
        _selectCharacterPanel.SetActive(true);
    }
    public void ChangeImage(int im)
    {
        _viewImage.sprite = _image[im];
    }
}
