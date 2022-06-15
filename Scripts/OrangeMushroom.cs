using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrangeMushroom : MonoBehaviour, ConsumableInterface
{
    public Texture t;
    public void consumedBy(GameObject player)
    {
        player.GetComponent<PlayerController>().maxSpeed *= 2;
        StartCoroutine(removeEffect(player));
    }

        IEnumerator removeEffect(GameObject player)
    {
        yield return new WaitForSeconds(5.0f);
        player.GetComponent<PlayerController>().maxSpeed /= 10;
    }
}
