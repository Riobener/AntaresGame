using UnityEngine;

public class BGScroll : MonoBehaviour
{

    public float scrollSpeed;
    public float tileSize = 17;
    
    
    private void Update()
    {
        transform.position = new Vector3(transform.position.x, -Mathf.Repeat(Time.time * scrollSpeed, tileSize),
            transform.position.z);
            
    }
}
