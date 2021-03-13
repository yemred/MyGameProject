using MyGameProject.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyGameProject.Abstract
{
    class BaseGamerManager : IGamerService
    {
        public virtual void Add(Gamer gamer)
        {
            Console.WriteLine("Oyunucu Kaydedildi");
        }

        public virtual void Delete(Gamer gamer)
        {
            Console.WriteLine("Oyuncu Güncelleştirildi");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Oyuncu Silindi");
        }
    }
}
