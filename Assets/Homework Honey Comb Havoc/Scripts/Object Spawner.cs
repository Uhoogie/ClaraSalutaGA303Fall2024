using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Cinemachine.CinemachineFreeLook;

public class ObjectSpawner : MonoBehaviour
{
    List<GameObject> prefabList = new List<GameObject>();
    public Transform Spawner;
    public GameObject Fruit1;
    public GameObject Fruit2;
    public GameObject Fruit3;
    public GameObject Fruit4;
    public GameObject RottenFruit;

    void Start()
    {
        fruitspawner(); //runs function at start
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void fruitspawner() 
    {
        for (int i = 0; i < 8; i++) //spawns in multiple
        {
            prefabList.Add(Fruit1);
            prefabList.Add(Fruit2);
            prefabList.Add(Fruit3);
            prefabList.Add(Fruit4);
            prefabList.Add(RottenFruit);


            int prefabIndex = UnityEngine.Random.Range(0, 5); //randomly selects from list ^^^
            Instantiate(prefabList[prefabIndex], Spawner.position, Spawner.rotation); //Spawns in random items from above
        }
    }
}
