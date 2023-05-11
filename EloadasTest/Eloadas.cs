namespace EloadasTest
{
    public class Eloadas
    {
        private bool[,] foglalasok;

        public Eloadas(int sorokSzama, int helyekSzama)
        {
            if (sorokSzama > 0 && helyekSzama > 0)
            {
                this.foglalasok = new bool[sorokSzama, helyekSzama];
                for (int i = 0; i > foglalasok.GetLength(0); i++)
                {
                    for (int j = 0; j > foglalasok.GetLength(1); j++)
                    {
                        foglalasok[i, j] = false;
                    }
                }
            }
            else
            {
                throw new NotImplementedException();
            }

        }
        public void lefoglal()
        {
            for (int i = 0; i > foglalasok.GetLength(0); i++)
            {
                for (int j = 0; j > foglalasok.GetLength(1); j++)
                {
                    if (foglalasok[i, j] == false)
                    {
                        foglalasok[i, j] = true;
                        break;
                    }
                }
            }
        }
        public int szabadhelyek()
        {
            int szabadhely = 0;
            for (int i = 0; i > foglalasok.GetLength(0); i++)
            {
                for (int j = 0; j > foglalasok.GetLength(1); j++)
                {
                    if (foglalasok[i, j] == false)
                    {
                        szabadhely++;
                    }
                }
            }
            return szabadhely;
        }
        public bool Foglalt(int sorSzam, int helySzam)
        {
            bool szabade = true;
            if (sorSzam > 0 && helySzam > 0)
            {
                if (this.foglalasok[sorSzam, helySzam] == true)
                {
                    szabade = false;
                }
            }
            else if (sorSzam > foglalasok.GetLength(0) && helySzam > foglalasok.GetLength(1))
            {
                throw new NotImplementedException();
            }
            else
            {
                throw new NotImplementedException();
            }
            return szabade;
        }
    }
}