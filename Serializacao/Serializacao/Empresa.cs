using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
//using Newtonsoft.Json;

namespace Serializacao
{
    public class Empresa
    {
        public string Nome { get; set; }
        public string Municipio { get; set; }
        public string UF { get; set; }

        // método serializador: 
        public string JsonSerializar(Empresa empresa, JsonSerializerOptions options)
        {
            return JsonSerializer.Serialize(empresa, options); // serializando o objeto "empresa" em um arquivo .json
        }

        // método desserializador: 
        /*   public static Empresa JsonDesserializar(string Json)
           {
               return JsonSerializer.Deserialize<Empresa>(Json); // desserializando um objeto em um aquivo .json
           }
       }*/
    }
}  