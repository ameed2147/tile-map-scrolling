using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class bagscr : MonoBehaviour
{
    public float speed ;
    public float end;
    public float start;

    private void Update()
    {
        transform.Translate(Vector2.down * speed * Time.smoothDeltaTime);

        if (transform.position.y <= end)

        {
            Vector2 pos = new Vector2(0f,start);
            transform.position = pos;
        }
    }
}
