using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class hareket : MonoBehaviour
{
    public Rigidbody2D top;
    public float ziplamaGucu;
    public Color turkuazRenk, morRenk, sariRenk, pembeRenk;
    public string mevcutRenk;
    public SpriteRenderer goruntuleyici;
    public Transform degistirici;
    public TextMeshProUGUI skorYazisi;
    public int skor;
    public Transform DoubleCember, Cember, Kare, kontrol1, kontrol2, kontrol3,kontrol4,kontrol5,kontrol6,DoubleCember1,Kare1,Cember1;
    public AudioSource ziplamaSesi;
    
     void Start()
    {
        

        RastgeleRenk();
       
        
    }
    void OnTriggerEnter2D(Collider2D temas)
    {
        if(temas.tag != mevcutRenk && temas.tag != "Renkdegistirici"&& temas.tag != "kontrol1" && temas.tag != "kontrol2" && temas.tag != "kontrol3")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        if(temas.tag == "Renkdegistirici")
        {
            skor+=10;
            degistirici.position = new Vector3(degistirici.position.x, degistirici.position.y + 8.5f, degistirici.position.z);
            RastgeleRenk();
        }
        if(temas.tag == "kontrol1")
        {
            kontrol1.position = new Vector3(kontrol1.position.x, kontrol1.position.y + 26.5f, kontrol1.position.z);
            Cember.position = new Vector3(Cember.position.x, Cember.position.y + 23.5f, Cember.position.z);
        }
        if (temas.tag == "kontrol2")
        {
            kontrol2.position = new Vector3(kontrol2.position.x, kontrol2.position.y + 24f, kontrol2.position.z);
            Kare.position = new Vector3(Kare.position.x, Kare.position.y + 23.5f, Kare.position.z);
        }
        if (temas.tag == "kontrol3")
        {
            kontrol3.position = new Vector3(kontrol3.position.x, kontrol3.position.y + 20.5f, kontrol3.position.z);
            DoubleCember.position = new Vector3(DoubleCember.position.x, DoubleCember.position.y + 24f, DoubleCember.position.z);
        }
        if (temas.tag == "kontrol4")
        {
            kontrol1.position = new Vector3(kontrol4.position.x, kontrol4.position.y + 26.5f, kontrol4.position.z);
            Cember1.position = new Vector3(Cember1.position.x, Cember1.position.y + 23.5f, Cember1.position.z);
        }
        if (temas.tag == "kontrol5")
        {
            kontrol1.position = new Vector3(kontrol1.position.x, kontrol1.position.y + 24f, kontrol1.position.z);
            Kare1.position = new Vector3(Kare1.position.x, Kare1.position.y + 23.5f, Kare1.position.z);
        }
        if (temas.tag == "kontrol6")
        {
            kontrol1.position = new Vector3(kontrol1.position.x, kontrol1.position.y + 20.5f, kontrol1.position.z);
            DoubleCember1.position = new Vector3(DoubleCember1.position.x, DoubleCember1.position.y + 24f, DoubleCember1.position.z);
        }
    }

    void Update()
    {
        skorYazisi.text = "Skor :" + skor;
        
        

        if (Input.GetKeyDown(KeyCode.Space))
        {
            top.velocity = Vector2.up * ziplamaGucu;
            ziplamaSesi.Play();
        
        }
    }
    void RastgeleRenk()
    {
        int Rastgele = Random.Range(0, 4);

        switch (Rastgele)
        {
            case 0:
                mevcutRenk = "Turkuaz";
                goruntuleyici.color = turkuazRenk;
                break;
            case 1:
                mevcutRenk = "Mor";
                goruntuleyici.color= morRenk;
                break;
            case 2:
                mevcutRenk = "Sari";
                goruntuleyici.color = sariRenk;
                break;
            case 3:
                mevcutRenk = "Pembe";
                goruntuleyici.color = pembeRenk;
                break;

        }
    }
}
