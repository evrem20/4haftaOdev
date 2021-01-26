using System;
using System.Collections.Generic;
using System.Text;

namespace _4haftaOdev
{
    class MyDictionary<Tkey, Tvalue>  //Ben mydictonaryimde Tkey ve Tvalue ile çalışıcam anlamına geliyor.

    {
        Tkey[] tkeys;             //
        Tvalue[] tvalues;

        public MyDictionary()    //Burası constructordır. Otomatik çalışır.
        {
            tkeys = new Tkey[0];         //0 elemanlı bir dizi oluşturduk.
            tvalues = new Tvalue[0];

        }

        public void Add(Tkey anahtar, Tvalue deger)
        {
            Tkey[] tempArray = tkeys;     //Geçiçi dizinin referansı tkeysin referansı. tkeysin reeransını tutuyor.
            Tvalue[] tempArray2 = tvalues;  //Önceki referansa bağlanan elemanlar silinmesin diye bu referansları geçici diziye tutturuyoruz.

            tkeys = new Tkey[tkeys.Length + 1];           //Burada newlediğimiz için değerler,referans numarası uçuyor o yüzden bu referansı birrine tutturmak için bir yukarıdaki işlem yapılır.
            tvalues = new Tvalue[tvalues.Length + 1];

            for (int i = 0; i < tempArray.Length; i++)
            {
                tkeys[i] = tempArray[i];
            }

            for (int i = 0; i < tempArray2.Length; i++)
            {
                tvalues[i] = tempArray2[i];

            }

            tkeys[tkeys.Length - 1] = anahtar;
            tvalues[tvalues.Length - 1] = deger;
        }


        public Tkey[] No
        {
            get { return tkeys; }

        }
        public Tvalue[] Isim
        {
            get { return tvalues; }
        }

    
    }
}
