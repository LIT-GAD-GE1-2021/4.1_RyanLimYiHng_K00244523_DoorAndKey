using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManagerScript : MonoBehaviour
{
    public static LevelManagerScript instance;
    bool isTilemapA ;
    public GameObject tileMapA;
    public GameObject tileMapB;
    // Start is called before the first frame update
    private void Awake()
    {
        isTilemapA = true;
        tileMapA.SetActive(true);
        tileMapB.SetActive(false);
    }
    void Start()
    {
        instance = this;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Switch()
    {
        isTilemapA = !isTilemapA;     
        tileMapA.SetActive(isTilemapA);
        tileMapB.SetActive(!isTilemapA);
    }
}
