using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hareket : MonoBehaviour
{
    public float _hiz;
    public int _puan=0;
    public Text puan;
    Hareket _hareket;
    public GameObject panel;
    // Start is called before the first frame update
    void Start()
    {
        puan.text = "PUAN : " + _puan.ToString();
        _hareket = GameObject.Find("Capsule_iki").GetComponent<Hareket>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "duvar")
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -39.22f);
        }
        if (other.gameObject.name == "duvar (1)")
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, 39.12f);
        }
        if (other.gameObject.name == "duvar (2)")
        {
            transform.position = new Vector3(23.88f, transform.position.y, transform.position.z);
        }
        if (other.gameObject.name == "duvar (3)")
        {
            transform.position = new Vector3(-15.69f, transform.position.y, transform.position.z);
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
            transform.position += new Vector3(_hiz * Time.deltaTime, 0, 0);
        if (Input.GetKey(KeyCode.S))
            transform.position += new Vector3(-_hiz * Time.deltaTime, 0, 0);
        if (Input.GetKey(KeyCode.A))
            transform.position += new Vector3(0, 0, _hiz * Time.deltaTime);
        if (Input.GetKey(KeyCode.D))
            transform.position += new Vector3(0, 0, -_hiz * Time.deltaTime);
        if (_puan == -1 || _hiz == 0)
        {
            panel.gameObject.SetActive(true);
            _hiz = 0;
        }
    }
}
