using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGeneratorController : MonoBehaviour
{
    public GameObject enemyPrefab;
    //Generar enemigos cada 1.75 segudos
    public float generatorTimer = 1.75f;
    // Start is called before the first frame update
    void Start()
    {
        //Generar un enemigo cada 1.75f segudnos
        InvokeRepeating("CreateEnemy",0f,generatorTimer);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void CreateEnemy()
    {
        Instantiate(enemyPrefab,transform.position,Quaternion.identity);
    }
}
