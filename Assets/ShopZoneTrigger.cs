using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopZoneTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag == "Player"){
            var miner = other.GetComponent<MinerMovement>();
            miner.canOpenShop = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other) {
        if(other.gameObject.tag == "Player"){
            var miner = other.GetComponent<MinerMovement>();
            miner.canOpenShop = false;
            HUDMaster.I.HideShop();
        }
    }
}
