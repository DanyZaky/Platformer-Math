using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestTrigger : MonoBehaviour
{
    public GameObject thisPlatform;
    public GameObject reward;
    public GameObject soalObject;
    public Sprite spriteDisabled, spriteEnabled;
    public Transform spawnReward;
    void Start()
    {
        thisPlatform.GetComponent<SpriteRenderer>().sprite = spriteEnabled;
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            thisPlatform.GetComponent<SpriteRenderer>().sprite = spriteDisabled;
            gameObject.GetComponent<BoxCollider2D>().isTrigger = false;
            GameObject rewardObj = Instantiate(reward, spawnReward);
            rewardObj.GetComponent<EnemyAI>().soalPanel = soalObject;
        }
    }
}
