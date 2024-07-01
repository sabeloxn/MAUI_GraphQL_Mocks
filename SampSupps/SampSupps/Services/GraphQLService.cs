using GraphQL.Client.Http;
using GraphQL.Client.Serializer.Newtonsoft;

namespace SampSupps.Services
{
    public class GraphQLService 
    {
        private static readonly string BaseUri = "";
//---------------------------------------------------------------------------------+
// GraphQL Client                                                                  +
//---------------------------------------------------------------------------------+ 
        public static async Task<GraphQLHttpClient> GetGraphqlClient()
        {
            var httpClient =  new HttpClient();

            return  new  GraphQLHttpClient(
            new GraphQLHttpClientOptions
            { 
                EndPoint = new Uri(BaseUri) 
            },
            new NewtonsoftJsonSerializer(),  httpClient );
        }
    }
}

