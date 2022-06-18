using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Organism : MonoBehaviour
{
    [SerializeField] public int age = 0;
    [SerializeField] public int lifeSpan = 100;

    
    [SerializeField] public int minMaturity = 18;
    [SerializeField] public int maxMaturity = 60;
    [SerializeField] public int peakMaturity = 40;
    bool isMature = false;

    float stat1 = 0;
    float stat2 = 0;
    float stat3 = 0;
    float stat4 = 0;
    float stat5 = 0;
    float stat6 = 0;

    public bool isAlive { get; private set; } = true;

    


    public void SetIsAlive(bool isAlive)
    {
        this.isAlive = isAlive;
    }



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
}
