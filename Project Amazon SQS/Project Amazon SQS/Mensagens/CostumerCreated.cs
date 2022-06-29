using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Project_Amazon_SQS.Mensagens
{
    public class CostumerCreated
    {
        [JsonPropertyName("id")]
        public int Id { get; init; }

        [JsonPropertyName("fullName")]
        public string FullName { get; init; } = default!;
    }
}
