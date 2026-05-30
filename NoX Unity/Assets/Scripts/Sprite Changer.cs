using UnityEngine;

public class SpriteChanger : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public SpriteRenderer theRenderer;
    void Start()
    {
        theRenderer.color = Color.green;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
