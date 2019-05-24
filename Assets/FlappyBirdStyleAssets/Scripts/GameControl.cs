using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameControl : MonoBehaviour
{
	// Single Instance
	public static GameControl instance;

	public GameObject gameOverText;
	public bool gameOver = false;
    public float scrollSpead = -1.5f;

    private int score = 0;
    public Text scoreText;

    // Start is called before the first frame update
    // void Start()
    // {
        
    // }

	// Awake is called before the game start
    void Awake()
    {
    	if(!instance)
    	{
    		instance = this;
    	}
    	else if(instance)
    	{
    		Destroy(gameObject);
    	}

    }

    // Update is called once per frame
    void Update()
    {
        if(gameOver && Input.GetKeyDown("space"))
        {
        	SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    public void BirdDied()
    {
    	gameOverText.SetActive(true);
    	gameOver = true;
    }

    public void BirdScored()
    {
        if(gameOver)
        {
            return;
        }
        score++;
        scoreText.text = "Score: " + score.ToString();
    }
}
