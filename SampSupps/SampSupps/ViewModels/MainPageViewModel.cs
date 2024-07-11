using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using SampSupps.Models;
using CommunityToolkit.Mvvm.Input;
using GraphQL;

namespace SampSupps.ViewModels;
public partial class MainPageViewModel : BaseViewModel
{
    public MainPageViewModel()
    {
        items = new ObservableCollection<items>();
        //sales = new ObservableCollection<sales>();
    }
    [ObservableProperty]
    ObservableCollection<items> items ;
    // [ObservableProperty]
    // ObservableCollection<sales> sales ;
    [ObservableProperty]
    private string id;
    [ObservableProperty]
    private bool couponUsed;
    [ObservableProperty]
    private string purchaseMethod;
    [ObservableProperty]
    private DateTime saleDate;
    [ObservableProperty]
    private string storeLocation;
    // #endregion
//---------------------------------------------------------------------------------+
// Get Sale Query                                                                  +
//---------------------------------------------------------------------------------+ 
    [RelayCommand]
    private async Task OnAppearing()
    {
        var query = @"query ($id: String!) {
                            sale(id: $id) {
                                storeLocation
                                saleDate
                                purchaseMethod
                                couponUsed
                                id
                                items {
                                id
                                name
                                price
                                quantity
                                tags
                                }
                            }
                        }";
        var saleReq = new GraphQLRequest
        {
            Query = query,

            Variables = new 
            {
                id = "5bd761dcae323e45a93ccfe8", 
            }
        };

        var graphQLResponse = await graphQLClient.SendQueryAsync<GraphQLResponse>(saleReq);

        Id = graphQLResponse.Data.sale.id;
        CouponUsed = graphQLResponse.Data.sale.couponUsed;
        PurchaseMethod= graphQLResponse.Data.sale.purchaseMethod;
        SaleDate = graphQLResponse.Data.sale.saleDate;
        StoreLocation = graphQLResponse.Data.sale.storeLocation;

        foreach(items item in graphQLResponse.Data.sale.items)
        {
            Items.Add(item);    
        }
    }

//---------------------------------------------------------------------------------+
// Get Sale Query                                                                  +
//---------------------------------------------------------------------------------+ 
    // [RelayCommand]
    // private async Task OnAppearing()
    // {
    //     Console.Write("");
    //     var query = @"query($limit: Int!) {
    //                     sales(limit: $limit) {
    //                         id
    //                         couponUsed
    //                         purchaseMethod
    //                         saleDate
    //                         storeLocation
    //                     }
    //                     }";
    //     var saleReq = new GraphQLRequest
    //     {
    //         Query = query,

    //         Variables = new 
    //         {
    //             limit = 3, 
    //         }
    //     };

    //     var graphQLResponse = await graphQLClient.SendQueryAsync<GraphQLResponse>(saleReq);

    //     foreach(sales sale in graphQLResponse.Data.sales)
    //     {
    //         Sales.Add(sale);    
    //     }
    // }
}