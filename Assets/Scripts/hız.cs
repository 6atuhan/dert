using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hız : MonoBehaviour
{
    Hareket _hareket;
    
    private void Start()
    {
        // hareket şeyini aldık. ama unity bulması için. nerde olduğunu bulduk. sonra componentini aldık.
        _hareket = GameObject.Find("Capsule").GetComponent<Hareket>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name=="Capsule")
        {
            _hareket._hiz += 5;
            _hareket._puan += 1;
            transform.position = new Vector3(Random.Range(-15.5f, 25), 0, Random.Range(-39, 39));
            _hareket.puan.text = "PUAN : " + _hareket._puan;
        }


    }
 
}
