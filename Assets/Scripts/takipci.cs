using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class takipci : MonoBehaviour
{
    Hareket _hareket;
    public NavMeshAgent dusman;
    Transform oyuncu;
    void Start()
    {
        oyuncu = GameObject.Find("Capsule").transform;
        _hareket = GameObject.Find("Capsule").GetComponent<Hareket>();
    }

    // Update is called once per frame
    void Update()
    {
        dusman.destination = oyuncu.position;   
        if(_hareket._puan >= 5)
        {
            GetComponent<NavMeshAgent>().acceleration = 80;
            transform.localScale = new Vector3(2, 0, 2);
        }
        if (_hareket._puan >=10)
        {
            GetComponent<NavMeshAgent>().acceleration = 140;
            transform.localScale = new Vector3(3, 0, 3);
        }
        if (_hareket._puan >= 15)
        {
            GetComponent<NavMeshAgent>().acceleration = 180;
            transform.localScale = new Vector3(4, 0, 4);
        }
        if (_hareket._puan >= 20)
        {
            GetComponent<NavMeshAgent>().acceleration = 260;
            transform.localScale = new Vector3(5, 0, 5);
        }
        if (_hareket._puan >= 30)
        {
            GetComponent<NavMeshAgent>().acceleration = 400;
            transform.localScale = new Vector3(6, 0, 6);
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Capsule")
        {
            _hareket._hiz = 0;
        }
    }
}
