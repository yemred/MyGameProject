using MyGameProject.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyGameProject.Abstract
{
    public interface IGamerCheckService
    {
        bool GamerCheckService(Gamer gamer);
    }
}
