using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        //Method injection
        public void BasvuruYap(IKrediManager krediManager,ILoggerService loggerService)
        {
            //KonutKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesabla();
            krediManager.Hesabla();
            loggerService.Log();
        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesabla();
            }
        }


    }
}
