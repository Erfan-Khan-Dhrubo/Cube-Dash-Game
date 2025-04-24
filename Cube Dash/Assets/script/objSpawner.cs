using UnityEngine;

public class objSpawner : MonoBehaviour
{
    public GameObject objPrefab;
    public float timeBetweenSpawns = 3;
    public float widthOffset = 7;

    private float _timer = 0;

    void Start()
    {
        spawn(); 
    }

    // Update is called once per frame
    void Update()
    {
        if (_timer < timeBetweenSpawns)
        {
            _timer += Time.deltaTime;
        }
        else
        {
            spawn();
            _timer = 0;
        }
    }

    void spawn()
    {
        float lowest = transform.position.x - widthOffset;
        float highest = transform.position.x + widthOffset;
        var newObj = Instantiate(objPrefab, new Vector3(Random.Range(lowest, highest), transform.position.z, transform.position.z), transform.rotation); // ?
        newObj.transform.localScale = new Vector3(Random.Range(1,10), newObj.transform.localScale.y, newObj.transform.localScale.z);
        
    }
}
