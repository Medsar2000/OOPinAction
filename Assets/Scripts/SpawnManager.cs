using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void createAnimal(int index)
    {     
        Vector3 randomPosition = new Vector3(Random.Range(-10,10),0,Random.Range(-10,10));
        
        Instantiate(animalPrefabs[index], randomPosition, animalPrefabs[index].transform.rotation);
    }

    public void createCow()
    {
        createAnimal(0);
    }
    public void createDeer()
    {
        createAnimal(1);
    }
    public void createHorse()
    {
        createAnimal(2);
    }
    public void createCat()
    {
        createAnimal(3);
    }
    public void createDog()
    {
        createAnimal(4);
    }
    public void createFox()
    {
        createAnimal(5);
    }


}
