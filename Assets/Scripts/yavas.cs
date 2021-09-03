using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yavas : MonoBehaviour
{

    Hareket _hareket;
    float yavaslama = 5;
    private void Start()
    {
        // hareket þeyini aldýk. ama unity bulmasý için. nerde olduðunu bulduk. sonra componentini aldýk.
        _hareket = GameObject.Find("Capsule").GetComponent<Hareket>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Capsule")
        {

            _hareket._hiz -= yavaslama;
            _hareket._puan -= 1;
            //GetComponent<MeshRenderer>().enabled = false;
            //z = 40 -40 x = 25 -16
            transform.position = new Vector3(Random.Range(-15.5f, 25), 0, Random.Range(-39, 39));
            yavaslama += 5;
            _hareket.puan.text = "PUAN : " + _hareket._puan;
        }
    }
}
