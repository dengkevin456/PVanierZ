using UnityEngine;

public class Tile : MonoBehaviour
{
    public SpriteRenderer outline;

    private void Awake()
    {
        outline.gameObject.SetActive(false);
    }

    private void OnMouseEnter()
    {
        outline.gameObject.SetActive(true);
    }

    private void OnMouseExit()
    {
        outline.gameObject.SetActive(false);
    }
}
