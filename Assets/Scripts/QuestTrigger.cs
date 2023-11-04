using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestTrigger : MonoBehaviour
{
    public GameObject thisPlatform;
    public GameObject reward;
    public Color colorDisabled;
    public Color colorEnabled;
    public Transform spawnReward;
    void Start()
    {
        thisPlatform.GetComponent<SpriteRenderer>().color = colorEnabled;
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            thisPlatform.GetComponent<SpriteRenderer>().color = colorDisabled;
            gameObject.GetComponent<BoxCollider2D>().isTrigger = false;
            Instantiate(reward, spawnReward);
        }
    }
}
