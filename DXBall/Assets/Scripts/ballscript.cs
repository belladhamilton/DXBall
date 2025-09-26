using UnityEngine;
using TMPro; // Use this if you’re using TextMeshPro
public class ball : MonoBehaviour
{

// Start is called before the first frame update
Rigidbody2D rb;
public float speed;
public Vector2 direction;
public int brickCount = 0;
public scoreScript1 score;

void Start()
{
    rb= GetComponent<Rigidbody2D>();
    direction= Vector2.one.normalized; //(1,1)
    score = GameObject.FindGameObjectWithTag("logic").GetComponent<scoreScript1>();
}

// Update is called once per frame
void Update()
{
    rb.linearVelocity= direction*speed;
}

void OnTriggerEnter2D(Collider2D collison){
    if (collison.gameObject.CompareTag("paddle")){
        direction.y = -direction.y;
    }

    else if (collison.gameObject.CompareTag("brick")){
        direction.y = -direction.y;
        Destroy(collison.gameObject);
        brickCount = brickCount + 1;
        score.addScore(1); // 1 means score happened
        Debug.Log("Bricks destroyed: " + brickCount);
    }
    else if (collison.gameObject.CompareTag("sideWall")){
        direction.x = -direction.x;
    }   
    else if (collison.gameObject.CompareTag("ceiling")){
        direction.y = -direction.y;
    }

    else if (collison.gameObject.CompareTag("bottomWall")){
        Debug.Log("Game Over");
        gameObject.SetActive(false);
        score.addScore(0); // 0 means game over
    }
  
}
}