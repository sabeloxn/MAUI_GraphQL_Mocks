using CommunityToolkit.Mvvm.ComponentModel;
using SampSupps.Services;
using GraphQL.Client.Http;

namespace SampSupps.ViewModels
{
    public partial class BaseViewModel : ObservableObject
    {   
    public static readonly GraphQLHttpClient graphQLClient = GraphQLService.GetGraphqlClient().Result;
    }
}
