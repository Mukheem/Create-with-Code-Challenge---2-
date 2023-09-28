using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float dogWaitTime = 0.75f;
    private bool holdDog = false;

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space) && !holdDog)
        {

            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            holdDog = true;
            StartCoroutine(dogInstantiation());

        }


    }

    IEnumerator dogInstantiation()
    {
        Debug.Log("Waiting for " + dogWaitTime + " seconds to release dog...");
        yield return new WaitForSeconds(dogWaitTime);
        holdDog = false;

    }
   
}
