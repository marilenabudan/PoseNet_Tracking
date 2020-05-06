using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public static Controller Instance; // reference to itself to be accessible from other scripts
    public int prefabID = 0;
    public GameObject coinPrefab;
    public GameObject squarePrefab;
    private List<Vector3> coinPositions = new List<Vector3>();

    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
        InitCoinPos();
        CreateCoin();

    }

    // Update is called once per frame
    void Update()
    {

    }


    public void CreateCoin()
    {
        Vector3 randomPosition = coinPositions[Random.Range(0, coinPositions.Count)];
        if (prefabID == 0)
        {
            GameObject coin = Instantiate(coinPrefab,
                                            randomPosition,
                                            coinPrefab.transform.rotation);
        }
        
        if (prefabID == 1)
        {
            GameObject coin = Instantiate(squarePrefab,
                                            randomPosition,
                                            squarePrefab.transform.rotation);
        }
    }

    private void InitCoinPos()
    {
        coinPositions.Add(new Vector3(0, 250, 0));
        coinPositions.Add(new Vector3(200, 200, 0));
        coinPositions.Add(new Vector3(250, 0, 0));
        coinPositions.Add(new Vector3(200, -200, 0));
        coinPositions.Add(new Vector3(0, -250, 0));
        coinPositions.Add(new Vector3(-200, -200, 0));
        coinPositions.Add(new Vector3(-250, 0, 0));
        coinPositions.Add(new Vector3(-200, -200, 0));
    }

    public void ChangePrefabID()
    {
        if (prefabID == 0)
        {
            prefabID = 1;
        }
        else if (prefabID == 1)
        {
            prefabID = 0; 
        }
    }
}
