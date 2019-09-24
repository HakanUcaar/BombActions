using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidateBomb
{

    public interface IBomb
    {
        void Booom();
    }

    public class Bomb : IBomb
    {
        public static Bomb CreateNewBomb()
        {
            return new Bomb();
        }
        public static Bomb CreateNewBomb(Func<bool> BooomCriter)
        {
            return new Bomb(BooomCriter);
        }

        public Bomb()
        {
        }
        public Bomb(Func<bool> BooomCriter)
        {
            this.Boombastik = BooomCriter;
        }

        public Func<bool> Boombastik { get; set; }
        public Func<bool> NextFunc { get; set; }
        public Func<bool> FailureFunc { get; set; }
        public Bomb NextBomb { get; set; }
        public Bomb FailureBomb { get; set; }

        public Bomb Next(Bomb Next)
        {
            this.NextBomb = Next;
            return this;
        }
        public Bomb NextExplosion(Func<bool> Func)
        {
            this.NextFunc = Func;
            return this; 
        }
        public Bomb Failure(Bomb Fail)
        {
            this.FailureBomb = Fail;
            return this;
        }
        public Bomb FailureExplosion(Func<bool> Func)
        {
            this.FailureFunc = Func;
            return this;
        }

        public void Booom()
        {
            if (Boombastik())
            {
                if (NextBomb != null)
                {
                    NextBomb.Booom();
                }
                if (NextFunc != null)
                {
                    NextFunc();
                }
            }
            else
            {
                if (FailureBomb != null)
                {
                    FailureBomb.Booom();
                }
                if (FailureFunc != null)
                {
                    NextFunc();
                }
            }
        }
    }

    public class Bomb<T> : IBomb
    {
        public static Bomb<T> CreateNewBomb()
        {
            return new Bomb<T>();
        }
        public static Bomb<T> CreateNewBomb(Func<bool> BooomCriter)
        {
            return new Bomb<T>(BooomCriter);
        }

        public Bomb()
        {
        }
        public Bomb(Func<bool> BooomCriter)
        {
            this.Boombastik = BooomCriter;
        }

        public Func<bool> Boombastik { get; set; }
        public Func<T> NextFunc { get; set; }
        public Func<T> FailureFunc { get; set; }
        public Bomb<T> NextBomb { get; set; }
        public Bomb<T> FailureBomb { get; set; }

        public Bomb<T> Next(Bomb<T> Next)
        {
            this.NextBomb = Next;
            return this;
        }
        public Bomb<T> NextExplosion(Func<T> Func)
        {
            this.NextFunc = Func;
            return this;
        }
        public Bomb<T> Failure(Bomb<T> Fail)
        {
            this.FailureBomb = Fail;
            return this;
        }
        public Bomb<T> FailureExplosion(Func<T> Func)
        {
            this.FailureFunc = Func;
            return this;
        }

        public void Booom()
        {
            if (Boombastik())
            {
                if (NextBomb != null)
                {
                    NextBomb.Booom();
                }
                if (NextFunc != null)
                {
                    NextFunc();
                }
            }
            else
            {
                if (FailureBomb != null)
                {
                    FailureBomb.Booom();
                }
                if (FailureFunc != null)
                {
                    NextFunc();
                }
            }
        }
    }
}
