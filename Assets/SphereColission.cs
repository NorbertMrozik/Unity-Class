using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereColission : MonoBehaviour
{

    public GameObject coin;

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("Coin"))
        {
            col.gameObject.SetActive(false);
        }
    }
    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Vector3 mousePos = Input.mousePosition;
            mousePos.z = 10.0f;       // we want 2m away from the camera position
            Vector3 objectPos = Camera.main.ScreenToWorldPoint(mousePos);
            Instantiate(coin, objectPos, Quaternion.identity);
        }
    }


}
