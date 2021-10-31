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
    public GameObject loseTextObject;
    private bool move;
    void Start() 
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        SetCountText ();
        winTextObject.SetActive(false);
        loseTextObject.SetActive(false);
        move = true;
    }
    void FixedUpdate() 
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0 ,moveVertical);

        if(move)rb.AddForce(movement * speed);
        else rb.velocity = Vector3.zero;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PickUp")) 
        {
            other.gameObject.SetActive(false);
            count++;
            SetCountText ();
        }
        if (other.gameObject.CompareTag("PickOut")) 
        {
            other.gameObject.SetActive(false);
            loseTextObject.SetActive(true);
            move = false;
        }
    }
    void SetCountText()
	{
		countText.text = "Count: " + count.ToString();

		if (count >= 12) 
		{
            // Set the text value of your 'winText'
            winTextObject.SetActive(true);
		}
	}
}
