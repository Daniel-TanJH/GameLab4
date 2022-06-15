using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Super jump for red mushroom
public class RedMushroom : MonoBehaviour, ConsumableInterface
{
    public Texture t;
    public int index;
    public void consumedBy(GameObject player)
    {
        player.GetComponent<PlayerController>().upSpeed += 10;
        StartCoroutine(removeEffect(player));
    }

    IEnumerator removeEffect(GameObject player)
    {
        yield return new WaitForSeconds(5.0f);
        player.GetComponent<PlayerController>().upSpeed -= 10;
    }

    void onCollisionEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            Debug.Log("RedMushroom Touch");
            CentralManager.centralManagerInstance.addPowerup(t, index, this);
            GetComponent<Collider2D>().enabled = false;
        }
    }
}