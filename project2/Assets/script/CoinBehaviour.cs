using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinBehaviour : MonoBehaviour
{
    GameMangerScript GMS;
    private float rotateSpeed = 10f;

    void Awake()
    {
        GMS = GameObject.Find("GameManager").GetComponent<GameMangerScript> ();
        GMS.cur_coins++;
    }

    void Update()
    {
        transform.Rotate(Vector3.left * rotateSpeed);
    }

    void OnTriggerEnter(Collider other)
    {
        if(other. gameObject.tag == "player")
        {
            Destroy(gameObject);
            GMS.cur_coins--;
            //ADDING SCORE
            GMS.UpdateUI();

        }
    }

}
