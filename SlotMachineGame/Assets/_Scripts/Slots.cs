using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slots : MonoBehaviour
{
    public GameController gameController;
    public float delta = 60f;
    public Sprite[] sprites;

    private SpriteRenderer spriteRenderer;
    private bool isStopped;
    private bool isPressed;
   
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        gameController = FindObjectOfType<GameController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!isPressed) return;
        if (isStopped) return;

        delta -= Time.deltaTime;
        if (delta>=0)
        {
            StartCoroutine(SwapSpite(delta));
        }
        else if (delta <= 0)
        {
            isStopped = true;
            gameController.finalprize.Add(spriteRenderer.sprite.name);
            delta = 5;
            gameController.button.interactable = true;
        }    
    }

    public void ButonPress()
    {
        gameController.button.interactable = false;
        isPressed = true;
        isStopped = false;
        gameController.finalprize.Clear();
        gameController.isPlaying = false;
    }

    IEnumerator SwapSpite(float delta)
    {
            int randm = Random.Range(0, sprites.Length);
            spriteRenderer.sprite = sprites[randm];
            yield return new WaitForSeconds(2f);
    }
}
