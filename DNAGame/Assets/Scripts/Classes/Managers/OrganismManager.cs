using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrganismManager : MonoBehaviour
{
    Texture2D texture;
    Sprite sprite;
    SpriteRenderer renderer;

    [SerializeField] private int organismWidth;
    [SerializeField] private int organismHeight;

    

    void Awake()
    {
        renderer = gameObject.AddComponent<SpriteRenderer>() as SpriteRenderer;
        // renderer.color = new Color(0.2f, 0.6f, 0.9f, 1.0f);

        transform.position = new Vector3(0.0f, 0.0f, 0.0f);
    }

    // Start is called before the first frame update
    void Start()
    {
        texture = GenerateTexture2D(organismWidth, organismHeight, new Vector3(0, 0, 0));
        sprite = GenerateSprite(organismWidth, organismHeight, texture);
        renderer.sprite = sprite;

    }

    // Update is called once per frame
    void Update()
    {
        // transform.position = new Vector3(Random.Range(0.0f, 0.1f), Random.Range(0.0f, 0.1f), 0);
    }

    private Texture2D GenerateTexture2D(int width, int height, Vector3 pos)
    {
        texture = new Texture2D(width,height);
        for (int y = 0; y < texture.height; y++)
        {
            for (int x = 0; x < texture.height; x++)
            {
                texture.SetPixel(x, y, new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f)));
            }
        }
        texture.filterMode = FilterMode.Point;

        texture.Apply();

        return texture;
    }

    private Sprite GenerateSprite(int width, int height, Texture2D texture)
    {
        Sprite sprite = Sprite.Create(texture, new Rect(0.0f, 0.0f, texture.width, texture.height), new Vector2(0.5f, 0.5f));

        return sprite;
    }
}
