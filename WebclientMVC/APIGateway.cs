using System.Net;
using Newtonsoft.Json;
using System.Text.Json.Serialization;
using APICrudclient.Models;

using System.Text;

namespace APICrudclient
{
    
    public class APIGateway
    {
        
        private string url ="http://localhost:5063/ api/Customer";

        private string url2 ="http://localhost:8000/ProductList";

        private string url3="http://localhost:8000/OrderList";

        private HttpClient httpClient = new HttpClient();

        public List<Customer> ListCustomers()
        {
           List<Customer> customers = new List<Customer>();
        //    if (url.Trim().Substring(0, 5).ToLower() == "https")
        //              ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                     

            try{
                HttpResponseMessage response = httpClient.GetAsync(url).Result;
                if(response.IsSuccessStatusCode)
                {
                    string result =response.Content.ReadAsStringAsync().Result;
                    var datacol = JsonConvert.DeserializeObject<List<Customer>>(result);

                    if (datacol != null)
                      customers =datacol;

                }

                else 
                 {
                        string result =response.Content.ReadAsStringAsync().Result;
                         throw new Exception("Error Occured at the API Endpoint,Error Info." + result);
                }
            }

                catch (Exception ex)
                {
                    throw new Exception("Error Occured at the API Endpoint,Error Info." + ex.Message);
                }

                finally{}
                return customers;
                 
        }

        public Customer CreateCustomer(Customer customer)
        {
          
           if (url.Trim().Substring(0, 5).ToLower() == "https")
                     ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            string json = JsonConvert.SerializeObject(customer);    

            try{
                HttpResponseMessage response = httpClient.PostAsync(url,new StringContent(json,Encoding.UTF8,"application/json")).Result;
                if(response.IsSuccessStatusCode)
                {
                    string result =response.Content.ReadAsStringAsync().Result;
                    var data = JsonConvert.DeserializeObject<Customer>(result);

                    if (data != null)
                        customer = data;

                }

                else 
                 {
                        string result =response.Content.ReadAsStringAsync().Result;
                         throw new Exception("Error Occured at the API Endpoint,Error Info." + result);
                }
            }

                catch (Exception ex)
                {
                    throw new Exception("Error Occured at the API Endpoint,Error Info." + ex.Message);
                }

                finally{}
                return customer;
                 
        }


    
    public Customer GetCustomer(int id)
        {
          Customer customer =new Customer();
          url = url + "/" + id;
           if (url.Trim().Substring(0, 5).ToLower() == "https")
                     ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            string json = JsonConvert.SerializeObject(customer);    

            try{
                 HttpResponseMessage response = httpClient.GetAsync(url).Result;
                if(response.IsSuccessStatusCode)
                {
                    string result =response.Content.ReadAsStringAsync().Result;
                    var data = JsonConvert.DeserializeObject<Customer>(result);

                    if (data != null)
                        customer = data;

                }

                else 
                 {
                        string result =response.Content.ReadAsStringAsync().Result;
                         throw new Exception("Error Occured at the API Endpoint,Error Info." + result);
                }
            }

                catch (Exception ex)
                {
                    throw new Exception("Error Occured at the API Endpoint,Error Info." + ex.Message);
                }

                finally{}
                return customer;
                 
        }


         public Customer UpdateCustomer(Customer customer)
        {
          
           if (url.Trim().Substring(0, 5).ToLower() == "https")
                     ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            int id = customer.Id; 
            url = url + "/" + id;

            string json = JsonConvert.SerializeObject(customer);   

            try{
                HttpResponseMessage response = httpClient.PutAsync(url,new StringContent(json,Encoding.UTF8,"application/json")).Result;
                if(response.IsSuccessStatusCode)
                {
                    string result =response.Content.ReadAsStringAsync().Result;
                    var data = JsonConvert.DeserializeObject<Customer>(result);

                    if (data != null)
                        customer = data;

                }

                else 
                 {
                        string result =response.Content.ReadAsStringAsync().Result;
                         throw new Exception("Error Occured at the API Endpoint,Error Info." + result);
                }
            }

                catch (Exception ex)
                {
                    throw new Exception("Error Occured at the API Endpoint,Error Info." + ex.Message);
                }

                finally{}
                return customer;
                 
        }

  
  public void DeleteCustomer(int id)
        {
          
           if (url.Trim().Substring(0, 5).ToLower() == "https")
                     ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
              url = url + "/" + id;
            

            try{
                 HttpResponseMessage response = httpClient.DeleteAsync(url).Result;
                if(!response.IsSuccessStatusCode)
                {
                    
                     string result =response.Content.ReadAsStringAsync().Result;
                         throw new Exception("Error Occured at the API Endpoint,Error Info." + result);

                }

                
            }

                catch (Exception ex)
                {
                    throw new Exception("Error Occured at the API Endpoint,Error Info." + ex.Message);
                }

                finally  {  }

                return;
                 
        }
 
        public List<ProductModel> ListProducts()
        {
           List<ProductModel> products = new List<ProductModel>();
           if (url.Trim().Substring(0, 5).ToLower() == "https")
                     ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                     

            try{
                HttpResponseMessage response = httpClient.GetAsync(url2).Result;
                if(response.IsSuccessStatusCode)
                {
                    string result =response.Content.ReadAsStringAsync().Result;
                    var data = JsonConvert.DeserializeObject<List<ProductModel>>(result);

                    if (data != null)
                      products =data;

                }

                else 
                 {
                        string result =response.Content.ReadAsStringAsync().Result;
                         throw new Exception("Error Occured at the API Endpoint,Error Info." + result);
                }
            }

                catch (Exception ex)
                {
                    throw new Exception("Error Occured at the API Endpoint,Error Info." + ex.Message);
                }

                finally{}
                return products;
                 
        }


 public List<OrderModel> ListOrder()
        {
           List<OrderModel> order = new List<OrderModel>();
           if (url.Trim().Substring(0, 5).ToLower() == "https")
                     ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                     

            try{
                HttpResponseMessage response = httpClient.GetAsync(url3).Result;
                if(response.IsSuccessStatusCode)
                {
                    string result =response.Content.ReadAsStringAsync().Result;
                    var data = JsonConvert.DeserializeObject<List<OrderModel>>(result);

                    if (data != null)
                       order =data;

                }

                else 
                 {
                        string result =response.Content.ReadAsStringAsync().Result;
                         throw new Exception("Error Occured at the API Endpoint,Error Info." + result);
                }
            }

                catch (Exception ex)
                {
                    throw new Exception("Error Occured at the API Endpoint,Error Info." + ex.Message);
                }

                finally{}
                return order;
                 
        }


     


    }
}











 