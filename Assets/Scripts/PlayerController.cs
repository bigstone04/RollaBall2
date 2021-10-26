using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;

    public float speed;

    private int count;

    public TextMeshProUGUI countText;
	public GameObject winTextObject;
    void Start() 
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        SetCountText ();
        winTextObject.SetActive(false);
    }
    void FixedUpdate() 
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0 ,moveVertical);

        rb.AddForce(movement * speed);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PickUp")) 
        {
            other.gameObject.SetActive(false);
            count++;
            SetCountText ();
        }
    }
    void SetCountText()
	{
		countText.text = "Count: " + count.ToString();

		if (count >= 5) 
		{
            // Set the text value of your 'winText'
            winTextObject.SetActive(true);
		}
	}
}
