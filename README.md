# BombActions
Sıralı Patlayan Olaylar Örgüsü

# Test Kod:
```Csharp
    class BombTest
    {
        public BombTest()
        {
            var Bomba =
                Bomb.CreateNewBomb(Explosion1)
                .Next(
                        Bomb.CreateNewBomb(Explosion2)
                        .Next(
                            Bomb.CreateNewBomb(Explosion1)
                            .NextExplosion(Explosion9)
                            .FailureExplosion(Explosion10)
                            )
                        .FailureExplosion(Explosion5)
                     )
                .Failure(
                        Bomb.CreateNewBomb(Explosion3)
                          .NextExplosion(Explosion6)
                          .FailureExplosion(Explosion7)
                        );
            Bomba.Booom();

            Console.ReadLine();
        }        

        public bool Explosion1()
        {
            Console.WriteLine("Explosion1");
            return true;
        }
        public bool Explosion2()
        {
            Console.WriteLine("Explosion2");
            return true;
        }
        public bool Explosion3()
        {
            Console.WriteLine("Explosion3");
            return true;
        }
        public bool Explosion4()
        {
            Console.WriteLine("Explosion4");
            return false;
        }
        public bool Explosion5()
        {
            Console.WriteLine("Explosion5");
            return true;
        }
        public bool Explosion6()
        {
            Console.WriteLine("Explosion6");
            return false;
        }
        public bool Explosion7()
        {
            Console.WriteLine("Explosion7");
            return false;
        }
        public bool Explosion8()
        {
            Console.WriteLine("Explosion8");
            return false;
        }
        public bool Explosion9()
        {
            Console.WriteLine("Explosion9");
            return false;
        }
        public bool Explosion10()
        {
            Console.WriteLine("Explosion10");
            return false;
        }
    }
```

# Çıktı:
![OrnekCikti](https://github.com/HakanUcaar/BombActions/blob/master/Cikti.png)
