using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Organism : MonoBehaviour
{
    [SerializeField] public bool _isAlive { get; private set; }
    [SerializeField] public int _age { get; private set; }
    [SerializeField] public int _lifeSpan { get; private set; }
    [SerializeField] public int _minMaturity { get; private set; }
    [SerializeField] public int _maxMaturity { get; private set; }
    [SerializeField] public int _peakMaturity { get; private set; }
    [SerializeField] public bool _isMature { get; private set; }

    float stat1 = 0;
    float stat2 = 0;
    float stat3 = 0;
    float stat4 = 0;
    float stat5 = 0;
    float stat6 = 0;


    public Organism()
    {
        this._isAlive = true;
        this._age = 0;
        this._isMature = false;
    }

    ~Organism()
    {

    }

    public void SetIsAlive(bool isAlive)
    {
        this._isAlive = isAlive;
    }

    public void Kill()
    {
        Destroy(this);
    }

    public void SetAge(int age)
    {
        this._age = age;
    }

    public void SetLifeSpan(int lifeSpan)
    {
        this._lifeSpan = lifeSpan;
    }
}
