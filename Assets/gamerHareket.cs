using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gamerHareket : MonoBehaviour
{
    public float yurumeHizi = 5f;
    public float donusHiz = 200f;
    public float ziplamaGucu = 50f;


    public int treeSayisi = 0;
    public Text txtTreeSayisi;
    public GameObject PanelGAMEOVER;

    public int toplamTreeSayisi;
    public int aktifLevelNo;

    private Animator animator;
    private Rigidbody rb;

    private bool havada = false;

    AudioSource audioSource;

    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        animator.SetBool("Yuruyor", false);

        if(Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * yurumeHizi * Time.deltaTime);
            animator.SetBool("Yuruyor", true);
        }
        if(Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.up,- donusHiz * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up, donusHiz * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back*yurumeHizi * Time.deltaTime);
        }
        if (Input.GetKeyDown(KeyCode.Space)&&havada==false)
        {
            havada = true;
            animator.SetBool("Zipla", true);
            rb.AddForce(Vector3.up * ziplamaGucu, ForceMode.Impulse);
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        animator.SetBool("Zipla", false);
        havada = false;

        if (collision.gameObject.tag == "TREE")
        {
            Destroy(collision.gameObject);
            treeSayisi++;
            txtTreeSayisi.text = "Tree Sayısı:" + treeSayisi.ToString();
            audioSource.Play();

            if (treeSayisi == toplamTreeSayisi)
            {
                Debug.Log("SONRAKİ LEVELI AÇ");
                SceneManager.LoadScene(aktifLevelNo + 1);
            }
           
        }
        if (collision.gameObject.tag == "MAYIN")
        {
            Destroy(collision.gameObject);
            PanelGAMEOVER.SetActive(true);
            gameObject.SetActive(false);  
            //Destroy(gameObject);
        }
    }
}