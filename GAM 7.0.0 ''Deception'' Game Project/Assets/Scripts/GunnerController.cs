using UnityEngine;

public class GunnerController : MonoBehaviour
{
	public float ZPositionOverride = -5;

	private CircleCollider2D CC2D;
	private SpriteRenderer SPR;

	private void Awake()
	{
		CC2D = GetComponent<CircleCollider2D>();
		SPR = GetComponent<SpriteRenderer>();
	}

	private void Update()
	{
		// Reset sprite color to white
		SPR.color = new Color(255, 255, 255);

		// Set sprite position to be where the mouse is on screen
		transform.position = new Vector3(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y, ZPositionOverride);

		// Just to test if clicking works, set the sprite color to red when clicking. This will be changed to actually
		// do stuff later
		if (Input.GetMouseButton(0))
		{
			print("GunnerController.Update() says \"Click\"");
			SPR.color = new Color(255, 0, 0);
		}
	}
}