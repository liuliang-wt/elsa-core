using System.Collections.Generic;
using System.Linq;
using System.Text;
using Elsa.Secrets.Models;

namespace Elsa.Secrets.ValueFormatters
{
    public class AuthorizationHeaderSecretValueFormatter : ISecretValueFormatter
    {
        public string Type => "Authorization";

        public string FormatSecretValue(Secret secret) => ConvertPropertiesToString(secret.Properties);

        private static string ConvertPropertiesToString(ICollection<SecretProperty> properties)
        {
            var sb = new StringBuilder();

            foreach (var property in properties.Where(x => x.Expressions.Count > 0))
            {
                sb.Append($"{property.Expressions.First().Value}");
            }

            return sb.ToString();
        }
    }
}