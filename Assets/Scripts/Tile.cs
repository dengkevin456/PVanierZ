using UnityEngine;

public class Tile : MonoBehaviour
{
    private SpriteRenderer tileSprite;
    private static Color originalColor;
    private void Awake()
    {
        tileSprite = GetComponent<SpriteRenderer>();
        originalColor = tileSprite.color;
    }

    private void OnMouseEnter()
    {
        tileSprite.color = new Color32(150, 150, 150, 70);
    }

    private void OnMouseExit()
    {
        tileSprite.color = originalColor;
    }
}
