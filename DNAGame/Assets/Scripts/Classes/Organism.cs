using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Organism : MonoBehaviour {
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

    private void Update() {
        RandomWalk();
    }

    public Organism() {
        this._isAlive = true;
        this._age = 0;
        this._isMature = false;
    }

    ~Organism() {

    }

    public void SetIsAlive( bool isAlive ) {
        this._isAlive = isAlive;
    }

    public void Kill() {
        Destroy( this );
    }

    public void SetAge( int age ) {
        this._age = age;
    }

    public void SetLifeSpan( int lifeSpan ) {
        this._lifeSpan = lifeSpan;
    }

    public void RandomWalk() {

        int randomNum = Random.Range( 0, 100 );
        switch ( randomNum ) {
            case 0:
                this.transform.Translate( new Vector3Int( 1, 0, 0 ) );
                break;
            case 1:
                this.transform.Translate( new Vector3Int( 0, 1, 0 ) );
                break;
            case 2:
                this.transform.Translate( new Vector3Int( -1, 0, 0 ) );
                break;
            case 3:
                this.transform.Translate( new Vector3Int( 0, -1, 0 ) );
                break;
            default:
                break;
        }
    }
}
