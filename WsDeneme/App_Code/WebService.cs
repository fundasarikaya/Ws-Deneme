using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

/// <summary>
/// WebService için özet açıklama
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// Bu Web Hizmeti'nin, ASP.NET AJAX kullanılarak komut dosyasından çağrılmasına, aşağıdaki satırı açıklamadan kaldırmasına olanak vermek için.
// [System.Web.Script.Services.ScriptService]
public class WebService : System.Web.Services.WebService
{

    public WebService()
    {

        //Tasarlanmış bileşenleri kullanıyorsanız şu satırı açıklamadan çıkarın
        //InitializeComponent(); 
    }

    [WebMethod]
    public string HelloWorld(string ad,string soyad)
    {
        return "Merhaba Dünya"+ad+" "+soyad;
    }
    [WebMethod]
    public int topla(int sayi1,int sayi2)
    {
        return sayi1 + sayi2;
    }

}
