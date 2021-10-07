using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestScript : MonoBehaviour
{
    [SerializeField] private Animator myAnimationController;
    public static bool anim_played = false;
    public GameObject panel;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            myAnimationController.SetBool("playAnimation", true);
            panel.SetActive(true);
            //Debug.Log(collision.gameObject.GetComponent<Rigidbody2D>().velocity.ToString());       
    
        }

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            myAnimationController.SetBool("playAnimation", false);
        }
    }
}
