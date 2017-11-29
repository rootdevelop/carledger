using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Carledger.Models;
using Newtonsoft.Json;

namespace Carledger.Services
{
    public static class CarledgerService
    {
        private static readonly HttpClient _client;

        static CarledgerService()
        {
            _client = new HttpClient {BaseAddress = new Uri("http://13.80.73.2:3000/api/")};
        }
       
        public static async Task<List<Owner>> GetOwners()
        {
            var res = await _client.GetStringAsync("Owner");

            return JsonConvert.DeserializeObject<List<Owner>>(res);
        }
        
        public static async Task<List<Car>> GetCars()
        {
            var res = await _client.GetStringAsync("Car");

            return JsonConvert.DeserializeObject<List<Car>>(res);
        }
        
        public static async Task ExecuteMileageTransaction(MileageTransaction transaction)
        {
            var transactionAsString = JsonConvert.SerializeObject(transaction);
            var result = await _client.PostAsync("MileageTransaction", new StringContent(transactionAsString, Encoding.UTF8, "application/json"));
        }
        
        public static async Task<List<MileageTransaction>> GetTransactions()
        {
            var res = await _client.GetStringAsync("MileageTransaction");

            return JsonConvert.DeserializeObject<List<MileageTransaction>>(res);
        }
      
    }
}