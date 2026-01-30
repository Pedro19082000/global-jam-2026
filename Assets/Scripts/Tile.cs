using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    [SerializeField] private Color _color1, _color2;
    [SerializeField] private SpriteRenderer _spriteRenderer;
    [SerializeField] private GameObject _highLight;


    public void setColor(bool isDiferent)
    {
        _spriteRenderer.color = isDiferent ? _color1 : _color2;
    }

    private void OnMouseEnter()
    {
        _highLight.SetActive(true);
    }

    private void OnMouseExit()
    {
        _highLight.SetActive(false);
    }

}
