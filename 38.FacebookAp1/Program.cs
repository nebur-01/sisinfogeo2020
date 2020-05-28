using System;
using Newtonsoft.Json;

namespace _38.FacebookAp1
{
    class Program
    {
        static void Main(string[] args)
        {

            //token
            string fbtoken  = "EAACyGR7aItABAHp2ZAphjx04BMfZB5pQjTtcuuwdTOu45k8DO4vQpMgdLm4ZA2WR1T75xCywPU8waf3NQ6F0Ql4vo1U3kLdpis1xN6jbphm7Tw61PvzK1ZBbOhs0tZAlECPypIeabt4V5sryvwheazZBb0v4J49ckCjBRC7OxxJt6CIsv7WsE1TkHHqEkp6J8ZD";
            string fbfields = "id,first_name,last_name,middle_name,name,name_format,picture,short_name,email";

            FacebookApi fb = new FacebookApi(fbtoken);

            string resultado = fb.ObtenerInfo(fbfields).Result;

            var res = JsonConvert.DeserializeObject(resultado);

            Console.WriteLine(res);
        }
    }
}
