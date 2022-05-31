using UnityEngine;

public class Border : MonoBehaviour
{
    private SpriteRenderer spRenderer;
    [SerializeField] private Camera cam;

    private void Start()
    {
        spRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {


        float derecha = (cam.WorldToScreenPoint(new Vector3 (transform.position.x + spRenderer.bounds.extents.x, 0, 0))).x;
        float izquierda = (cam.WorldToScreenPoint(new Vector3(transform.position.x - spRenderer.bounds.extents.x, 0, 0))).x;
        float arriba = (cam.WorldToScreenPoint(new Vector3(0, transform.position.y + spRenderer.bounds.extents.y, 0))).y;
        float abajo = (cam.WorldToScreenPoint(new Vector3(0, transform.position.y - spRenderer.bounds.extents.y, 0))).y;

        if (derecha > Screen.width)
        {
            spRenderer.transform.position = new Vector3(transform.position.x - 0.1f, transform.position.y, 0);
        }

        if (izquierda < 0)
        {
            spRenderer.transform.position = new Vector3(transform.position.x + 0.1f, transform.position.y, 0);
        }

        if (arriba > Screen.height)
        {
            spRenderer.transform.position = new Vector3(transform.position.x, transform.position.y - 0.1f, 0);
        }

        if (abajo < 0)
        {
            spRenderer.transform.position = new Vector3(transform.position.x, transform.position.y + 0.1f, 0);
        }
    }
}
