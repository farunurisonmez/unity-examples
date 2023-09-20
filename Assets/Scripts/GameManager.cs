using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

/**
 * Bu script, oyunun ana kontrolünü sağlayan GameManager sınıfını temsil eder.
 * GameManager, oyun tahtasını oluşturur ve oyunun genel akışını yönetir.
 **/

public class GameManager : MonoBehaviour
{
    /**
     * GameManager sınıfından statik örneğe erişim.
     * Bu şekilde, instance kullanarak GameManager sınıfının tüm yöntemlerine ve özelliklerine erişebilirsiniz.
     **/
    public static GameManager instance;

    /**
     * hexPrefab değişkeni, Unity Inspector panelinde görünür ve hexPrefab'in atanabileceği bir alandır.
     **/
    [SerializeField] public Hex hexPrefab;


    /**
     * Awake metodu, oyun nesnelerinin başlatılmasından hemen önce çağrılır.
     **/
    private void Avake()
    {
        /**
         * hexPrefab nesnesinin SpriteRenderer bileşenini alıyoruz.
         **/
        SpriteRenderer spriteRenderer = hexPrefab.GetComponent<SpriteRenderer>();

        Debug.Log(spriteRenderer);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
