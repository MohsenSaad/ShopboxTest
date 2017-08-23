using ShopBox.DTO;
using ShopBox.Models.Branches;
using ShopBox.Models.Clients;
using ShopBox.Models.Products;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopBox.MappingLayer
{
    /// <summary>
    /// class to map the service model to DTO AutoMapper not supported yet in the Xamrine PCL project
    /// </summary>
    public class DTOMapper
    {

         #region methods
        /// <summary>
        ///  method to map the Branch service model to DTO model manual 
        /// </summary>
        /// <param name="Branchrootobject"></param>
        /// <returns></returns>
        public ObservableCollection<BranchDataDTO> MapBranchserviceModelToDTOModel(BranchRootObject Branchrootobject)
        {
            ObservableCollection<BranchDataDTO> branchCollection = new ObservableCollection<BranchDataDTO>();
            BranchDataDTO _branch;
            for(int i=0; i< Branchrootobject.data.Count;i++)
            {
                _branch = new BranchDataDTO();
                _branch.uid = Branchrootobject.data[i].uid;
                _branch.name = Branchrootobject.data[i].name;
                _branch.phone = Branchrootobject.data[i].phone;
                _branch.client = Branchrootobject.data[i].client;
                 branchCollection.Add(_branch);
            }
            return branchCollection;
        }

        /// <summary>
        /// method to map the client service model to DTO model manual 
        /// </summary>
        /// <param name="rootobject"></param>
        /// <returns></returns>
        public ObservableCollection<ClientDataDTO> MapClientserviceModelToDTOModel(ClientModel clientrootobject)
        {
            ObservableCollection<ClientDataDTO> ClientCollection = new ObservableCollection<ClientDataDTO>();
            ClientDataDTO _client;
            for (int i = 0; i < clientrootobject.clients.Count; i++)
            {
                _client = new ClientDataDTO();
                _client.uid = clientrootobject.clients[i].client.uid;
                _client.name = clientrootobject.clients[i].client.name;
                _client.phone = clientrootobject.clients[i].client.phone;
                _client.email = clientrootobject.clients[i].client.email;
                ClientCollection.Add(_client);
            }
            return ClientCollection;
        }

        /// <summary>
        /// method to map the product service model to DTO model manual 
        /// </summary>
        /// <param name="rootobject"></param>
        /// <returns></returns>
        public ObservableCollection<ProductDataDTO> MapProductserviceModelToDTOModel(ProductModel productrootobject)
        {
            ObservableCollection<ProductDataDTO> ProductCollection = new ObservableCollection<ProductDataDTO>();
            ProductDataDTO _product;
            for (int i = 0; i < productrootobject.products.Count; i++)
            {
                _product = new ProductDataDTO();
                _product.uid = productrootobject.products[i].uid;
                _product.name = productrootobject.products[i].name;
                _product.selling_price = productrootobject.products[i].selling_price;
                _product.stock_price = productrootobject.products[i].stock_price;
                ProductCollection.Add(_product);
            }
            return ProductCollection;
        }
        #endregion

    }
}
