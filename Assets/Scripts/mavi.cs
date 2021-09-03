using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mavi : MonoBehaviour
{
    HareketMavi _hareket;
    HareketKirmizi _hareket2;
    void Start()
    {
        _hareket = GameObject.Find("Capsule").GetComponent<HareketMavi>();
        _hareket2 = GameObject.Find("Capsule_iki").GetComponent<HareketKirmizi>();
    }


    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name=="Capsule")
        {
            _hareket._puan += 1;
            _hareket._hiz += 5;
            _hareket.puan.text = "PUAN : " + _hareket._puan;
            transform.position = new Vector3(Random.Range(-15.5f, 25), 0, Random.Range(-39, 39));
            GameObject.Find("Capsule").GetComponent<Transform>().localScale += new Vector3(0.1f, 0, 0.1f);
            
        }
        if(other.gameObject.name=="Capsule_iki")
        {
            _hareket2._puan -= 1;
            _hareket2._hiz -= 5;
            _hareket2.puan.text = "PUAN : " + _hareket2._puan;
            transform.position = new Vector3(Random.Range(-15.5f, 25), 0, Random.Range(-39, 39));
            GameObject.Find("Capsule_iki").GetComponent<Transform>().localScale += new Vector3(1f, 0, 1f);
        }
    }
}
