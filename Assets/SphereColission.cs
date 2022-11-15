using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SphereColission : MonoBehaviour
{
    public TMP_Text scoreText;
    private int score;
    public GameObject coin;
    public ParticleSystem explosionParticle;
    public ParticleSystem coinParticle;
    public Transform ballPos;

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("Coin"))
        {
            col.gameObject.SetActive(false);
            score++;
            scoreText.text = "Score: " + score;
            Instantiate(coinParticle, transform.position, transform.rotation);
        }
    }

    void OnCollisionEnter(Collision coll)
    {
        if (coll.gameObject.CompareTag("Plane"))
        {
            Debug.Log("Plane collided");
            Instantiate(explosionParticle, transform.position, transform.rotation);
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
