using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlotRotation : MonoBehaviour
{
    private float randomValue;
    private float timeInterval;

    bool spineStopped;
    bool rowStopped;

    public void PlayBtn()
    {

    }

    IEnumerator SpinSlots()
    {
        rowStopped = false;
        timeInterval = 0.025f;

        for (int i = 0; i < 30; i++)
        {
            if (transform.position.y == -3.5f)
            {
                transform.position = new Vector2(transform.position.x, 1.75f);
            }

            transform.position = new Vector2(transform.position.x, transform.position.y);

            yield return new WaitForSeconds(timeInterval);
        }

        randomValue = Random.Range(60, 100);

        switch (randomValue % 3)
        {
            case 1:
                randomValue += 3;
                break;
            case 2:
                randomValue += 1;
                break;
        }

        for (int i = 0; i < randomValue; i++)
        {
            if (transform.position.y <= -3.5f)
            {

            }
            
        }
    }

}
