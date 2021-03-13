using MerinsServiceReference;
using MyGameProject.Abstract;
using MyGameProject.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyGameProject.Adapter
{
    public class MerinsCheckAdapter : IGamerCheckService
    {
        public bool GamerCheckService(Gamer gamer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);

            return client.TCKimlikNoDogrulaAsync(long.Parse(gamer.NationalityId), gamer.FirstName, gamer.LastName, (gamer.DateOfBirth).Year).Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
