using MyGameProject.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyGameProject.Concrete
{
    class GamerManager : BaseGamerManager
    {
        IGamerCheckService _gamerCheckService;

        public GamerManager(IGamerCheckService gamerCheckService)
        {
            _gamerCheckService = gamerCheckService;
        }

        public override void Add(Gamer gamer)
        {
            if(_gamerCheckService.GamerCheckService(gamer))
            {
                Console.WriteLine("Merins Kontrolü Yapıldı ve Eklendi");
            }
            else
            {
                throw new Exception("Hata Bu Şekilde Bu Kullanıcı Bulunamadı");
            }
        }

    }
}
