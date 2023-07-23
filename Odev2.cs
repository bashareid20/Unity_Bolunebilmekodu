using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Odev2 : MonoBehaviour
{
   void BolenleriBul(int ilkSayi,int sonSayi)
    {
         
      
        ArrayList BenimListem = new ArrayList();

        for (int i = ilkSayi; i <= sonSayi; i++)
        {
            BenimListem.Add(i);


        }
        string Listem = "";
        foreach (int elman in BenimListem)
        {
            Listem += " _ " + elman;
            

        }
        print("Tüm Liste"+Listem);

       
        string Listem2 = "";
        foreach (int elman in BenimListem)
        {
            if ((elman%2)==0)
            {
                Listem2 += " _ " + elman;
            }
        }
        print("Ýkiye Tam Bölünebilen"  + Listem2);
        string Listem3 = "";
        foreach (int elman in BenimListem)
        {
            if ((elman%3)==0)
            {
                Listem3 += " _ " + elman;
            }
        }
        print("Üçe Tam Bölünebilen"  + Listem3); 
 
        string Listem4 = "";
        foreach (int elman in BenimListem)
        {
            if ((elman%4)==0)
            {
                Listem4 += " _ " + elman;
            }
        }
        print("Dörde Tam Bölünebilen"  + Listem4); 
        string Listem5 = "";
        foreach (int elman in BenimListem)
        {
            if ((elman%5)==0)
            {
                Listem5 += " _ " + elman;
            }
        }
        print("Beþe Tam Bölünebilen"  + Listem5);


    }

    void Start()
    {
        BolenleriBul(3, 20);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
