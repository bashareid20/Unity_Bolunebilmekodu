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
        print("T�m Liste"+Listem);

       
        string Listem2 = "";
        foreach (int elman in BenimListem)
        {
            if ((elman%2)==0)
            {
                Listem2 += " _ " + elman;
            }
        }
        print("�kiye Tam B�l�nebilen"  + Listem2);
        string Listem3 = "";
        foreach (int elman in BenimListem)
        {
            if ((elman%3)==0)
            {
                Listem3 += " _ " + elman;
            }
        }
        print("��e Tam B�l�nebilen"  + Listem3); 
 
        string Listem4 = "";
        foreach (int elman in BenimListem)
        {
            if ((elman%4)==0)
            {
                Listem4 += " _ " + elman;
            }
        }
        print("D�rde Tam B�l�nebilen"  + Listem4); 
        string Listem5 = "";
        foreach (int elman in BenimListem)
        {
            if ((elman%5)==0)
            {
                Listem5 += " _ " + elman;
            }
        }
        print("Be�e Tam B�l�nebilen"  + Listem5);


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
