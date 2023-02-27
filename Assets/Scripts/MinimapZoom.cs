using UnityEngine;

public class MinimapZoom : MonoBehaviour
{
    public Camera minimapCamera; 
    void Update()
    {
        if (Input.GetKeyDown("c"))
        {
            if (minimapCamera.orthographicSize != 15f)
            {
                // minimapCamera.orthographicSize = Mathf.Lerp(10f,5f,2 * Time.deltaTime);
                minimapCamera.orthographicSize = 15f;
                return;
            }
            if (minimapCamera.orthographicSize != 20f)
            {
                // minimapCamera.orthographicSize = Mathf.Lerp(5f,10f,2 * Time.deltaTime);
                minimapCamera.orthographicSize = 20f;
            }
        }
    }
}
