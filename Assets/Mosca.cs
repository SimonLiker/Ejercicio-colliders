using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Mosca : MonoBehaviour
{

    Vector3 initialPos;
    Quaternion initialRotation;
    public bool hasKey;
    public bool hasKey2;
    public bool hasKey3;
    public GameObject key;
    public GameObject key2;
    public GameObject key3;

    int lives = 3;
    int scoreCount;

    UIManager UIshortcut;

    // Start is called before the first frame update
    void Start()
    {
        initialPos = transform.position;
        initialRotation = transform.rotation;

        UIshortcut = FindObjectOfType<UIManager>();
        UIshortcut.txtLives.text = lives.ToString();
        UIshortcut.txtScore.text = scoreCount.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        key = GameObject.FindGameObjectWithTag("key");
        key2 = GameObject.FindGameObjectWithTag("key2");
        key3 = GameObject.FindGameObjectWithTag("key3");
        if (hasKey && hasKey2 && hasKey3)
        {
            Debug.Log("Ganó");
        }

        if (lives <= 0)
        {
            playerDeath();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ventilador" || collision.gameObject.tag == "pared")
        {
            LoseLife();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "key")
        {
            increaseScore();
            Destroy(key);
        }
        
    }

    void playerDeath()
    {
        Destroy(gameObject);
    }
    void LoseLife()
    {
        transform.position = initialPos;
        transform.rotation = initialRotation;
        lives--;
        UIshortcut.txtLives.text = lives.ToString();
    }

    void increaseScore()
    {
        scoreCount += 1;
        UIshortcut.txtScore.text = scoreCount.ToString();
    }
}
