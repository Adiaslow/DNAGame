using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrganismManager : MonoBehaviour {
    [SerializeField] Organism organismPrefab;

    List<Organism> Organisms = new List<Organism>();

    Texture2D texture;
    Sprite sprite;
    SpriteRenderer renderer;

    [SerializeField] private Vector2Int organismSizeInPixels;
    [SerializeField] private Vector3 scale;
    [SerializeField] private int organismCount;
    private int organismIndex = 0;


    List<string> nameParts = new List<string> { "a", "i", "u", "e", "o", "ka", "ki", "ku", "ke", "ko",
                                                "ta", "chi", "tsu", "te", "to", "sa", "shi", "su", "se",
                                                "so", "na", "ni", "nu", "ne", "no", "n", "ha", "hi",
                                                "fu", "he", "ho", "ma", "mi", "mu", "me", "mo", "ya",
                                                "yu", "yo", "ra", "ri", "ru", "re", "ro", "wa", "wo" };

    private string name;

    // Start is called before the first frame update
    void Start() {
        for (int i = 0; i < organismCount; i++) {
            GenerateOrganism(new Vector3(i * (float)(organismSizeInPixels.x / scale.x), 0, 0));
            }
        }

    // Update is called once per frame
    void Update() {
        // transform.position = new Vector3(Random.Range(0.0f, 0.1f), Random.Range(0.0f, 0.1f), 0);
        }

    public void GenerateOrganism(Vector3 pos) {
        Organism spawnedOrganism = Instantiate(organismPrefab, pos, Quaternion.identity);
        renderer = spawnedOrganism.GetComponent<SpriteRenderer>();
        texture = GenerateTexture2D(organismSizeInPixels, new Vector3(0, 0, 0));
        sprite = GenerateSprite(organismSizeInPixels, texture);
        renderer.sprite = sprite;
        spawnedOrganism.transform.localScale = scale;

        // spawnedOrganism.transform.position = pos;


        organismIndex++;
        spawnedOrganism.name = GenerateRandomName() + " " + organismIndex.ToString();
        name = "";
        Organisms.Add(spawnedOrganism);

        }

    private Texture2D GenerateTexture2D(Vector2Int organismSizeInPixels, Vector3 pos) {
        texture = new Texture2D(organismSizeInPixels.x, organismSizeInPixels.y);

        for (int y = 0; y < texture.height; y++) {
            for (int x = 0; x < texture.height; x++) {
                texture.SetPixel(x, y, new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f)));
                }
            }
        texture.filterMode = FilterMode.Point;
        texture.Apply();

        return texture;
        }

    private Sprite GenerateSprite(Vector2Int organismSizeInPixels, Texture2D texture) {
        return sprite = Sprite.Create(texture, new Rect(0.0f, 0.0f, texture.width, texture.height), new Vector2(0.0f, 0.0f));
        }

    private string GenerateRandomName() {
        for (int n = 0; n < Random.Range(2, 5); n++) name += nameParts[Random.Range(0, nameParts.Count)];
        return name = char.ToUpper(name[0]).ToString() + name.Substring(1);
        }
    }
