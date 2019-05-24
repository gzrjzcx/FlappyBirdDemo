using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnPool : MonoBehaviour
{

	public GameObject columnPrefab;

	public int columnPoolSize = 5;
	public float spawnRate = 4f; //4 seconds
	public float columnMinY = 0f;
	public float columnMaxY = 2.5f;
	public float spawnPosX = 10f;

	private GameObject[] columns;
	private Vector2 objectPoolPos = new Vector2(-15f, -25f);
	private float spawnInterval;
	private int currentColumn = 0;

    // Start is called before the first frame update
    void Start()
    {
        columns = new GameObject[columnPoolSize];
        for(int i=0; i<columnPoolSize; i++)
        {
        	columns[i] = (GameObject)Instantiate(columnPrefab, objectPoolPos, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        spawnInterval += Time.deltaTime;

        if(!GameControl.instance.gameOver && spawnInterval >= spawnRate)
        {
        	spawnInterval = 0;
        	float spawnPosY = Random.Range(columnMinY, columnMaxY);
        	columns[currentColumn].transform.position = new Vector2(spawnPosX, spawnPosY);
        	currentColumn++;
        	if(currentColumn >= columnPoolSize)
        		currentColumn = 0;
        }
    }
}
