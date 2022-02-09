using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cell : MonoBehaviour
{
    public System.Action<Cell> onCellPressed;
    public int playerId { get; private set; } = -1;

    [SerializeField] private Image cellBg;
         
    public void SetId(int id) 
    {
        playerId = id;
        GetImage();
    }

    public void ClickOnCell() 
    {
        onCellPressed?.Invoke(this);
    }


    public void GetImage()
    {
        int currentImage = playerId == 0 ? 1 : 2;
        Texture2D texture = Resources.Load<Texture2D>(currentImage.ToString());
        Sprite sprites = Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), new Vector2(.5f, .5f));
        cellBg.sprite = sprites;
    }


}
